using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using EliteSmile.Models;

namespace EliteSmile.Data
{
    public class PatientRepository
    {
        private readonly string connectionString = DatabaseInitializer.connectionString;

        public PatientRepository()
        {
            //string dbPath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "data.db");
            //string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data.db");
            //connectionString = "Data Source=" + dbPath + ";Version=3;";
        }

        public void Add(Patient patient)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string sql = @"INSERT INTO Patients 
                               (Name, Phone, FileNumber, DoctorName, Date, TreatmentPlan) 
                               VALUES (@Name, @Phone, @FileNumber, @DoctorName, @Date, @TreatmentPlan)";

                using (var cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", patient.Name);
                    cmd.Parameters.AddWithValue("@Phone", patient.Phone);
                    cmd.Parameters.AddWithValue("@FileNumber", patient.FileNo);
                    cmd.Parameters.AddWithValue("@DoctorName", patient.DoctorName);
                    cmd.Parameters.AddWithValue("@Date", patient.Date);
                    cmd.Parameters.AddWithValue("@TreatmentPlan", patient.TreatmentPlan);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Patient> GetAll()
        {
            var patients = new List<Patient>();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM Patients ORDER BY Id DESC";

                using (var cmd = new SQLiteCommand(sql, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        patients.Add(new Patient
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Phone = reader.IsDBNull(2) ? "" : reader.GetString(2),
                            FileNo = reader.IsDBNull(3) ? "" : reader.GetString(3),
                            DoctorName = reader.IsDBNull(4) ? "" : reader.GetString(4),
                            Date = reader.IsDBNull(5) ? "" : reader.GetString(5),
                            TreatmentPlan = reader.IsDBNull(6) ? "" : reader.GetString(6),
                        });
                    }
                }
            }

            return patients;
        }
    }
}
