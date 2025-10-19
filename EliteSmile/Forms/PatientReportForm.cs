using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace EliteSmile.Forms
{
    public partial class PatientReportForm : Form
    {
        private string connectionString = DatabaseInitializer.connectionString;
        private int _PationtID;

        public PatientReportForm(int PationtID)
        {
            InitializeComponent();
            _PationtID = PationtID;
        }

        private void PatientReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string sql = @"SELECT 
                              p.id,
                              p.name,
                              p.phone,
                              p.fileNo,
                              p.plan,
                              p.date,
                              u.name AS DoctorName
                           FROM Patients p
                           LEFT JOIN Users u ON p.DoctorId = u.id
                           WHERE p.id = @id";

                    using (var adapter = new SQLiteDataAdapter(sql, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@id", _PationtID);

                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView1.DataSource = dt;


                    }
                    //using (var cmd = new SQLiteCommand(sql, connection))
                    //{
                    //    cmd.Parameters.AddWithValue("@id", _PationtID);

                        //using (var reader = cmd.ExecuteReader())
                        //{
                        //    var list = new List<Patient>();

                        //    while (reader.Read())
                        //    {
                        //        list.Add(new Patient
                        //        {
                        //            Id = reader.GetInt32(0),
                        //            Name = reader.GetString(1),
                        //            Phone = reader.IsDBNull(2) ? "" : reader.GetString(2),
                        //            FileNo = reader.IsDBNull(3) ? "" : reader.GetString(3),
                        //            Plan = reader.IsDBNull(4) ? "" : reader.GetString(4),
                        //            Date = reader.IsDBNull(5) ? "" : reader.GetString(5),
                        //            DoctorName = reader.IsDBNull(6) ? "" : reader.GetString(6),
                        //            DoctorId = 1,
                        //        });
                        //    }

                        //    Crystal_Pationt report = new Crystal_Pationt();
                        //    report.SetDataSource(list); // ✅ مباشرة من List<Patient>

                        //    crystalReportViewer1.ReportSource = report;
                        //    crystalReportViewer1.Zoom(120);
                        //    crystalReportViewer1.Refresh();
                        //}
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل البيانات: " + ex.Message);
            }
        }
    }
}
