using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace EliteSmile
{
    public static class DatabaseInitializer
    {
        public static string dbPath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "DataBase.db");
        public static string connectionString = "Data Source=" + dbPath + ";Version=3;";


        public static void Initialize()
        {

            //string dbPath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "DataBase.db");
            //string connectionString = "Data Source=" + dbPath + ";Version=3;";
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    
                    string queryFile = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "query.txt");
                    string sql = File.ReadAllText(queryFile);

                    using (var cmd = new SQLiteCommand(sql, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            //using (var connection = new SQLiteConnection(connectionString))
            //{
                //connection.Open();

                //AddUniqueConstraintIfNotExists(connection, "Patients", "name");
            //}
            
        }

        private static void AddColumnIfNotExists(SQLiteConnection conn, string table, string column, string type)
        {
            string check = "PRAGMA table_info("+table+");";
            using (var cmd = new SQLiteCommand(check, conn))
            using (var reader = cmd.ExecuteReader())
            {
                bool exists = false;
                while (reader.Read())
                {
                    if (reader["name"].ToString().Equals(column, StringComparison.OrdinalIgnoreCase))
                    {
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                {
                    string alter = "ALTER TABLE " + table + " ADD COLUMN " + column +" "+ type+ ";";
                    using (var alterCmd = new SQLiteCommand(alter, conn))
                    {
                        alterCmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private static void AddUniqueConstraintIfNotExists(SQLiteConnection conn, string table, string column)
        {
            bool isUnique = false;

            // التحقق من الفهارس الموجودة على الجدول
            string checkIndexQuery = "PRAGMA index_list("+table+");";
            using (var cmd = new SQLiteCommand(checkIndexQuery, conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string indexName = reader["name"].ToString();
                    string isUniqueFlag = reader["unique"].ToString();

                    // إذا كان الفهرس فريدًا ويحمل اسم العمود، نعتبره موجودًا
                    if (isUniqueFlag == "1" && indexName.ToLower().Contains(column.ToLower()))
                    {
                        isUnique = true;
                        break;
                    }
                }
            }

            // إذا لم يكن هناك فهرس فريد على العمود، ننشئه
            if (!isUnique)
            {
                string indexName = "idx_"+table+"_"+column+"_unique";
                string createIndex = "CREATE UNIQUE INDEX IF NOT EXISTS " + indexName + " ON " + table + "(" + column + ");";

                using (var cmd = new SQLiteCommand(createIndex, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
