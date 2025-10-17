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
        }
    }
}
