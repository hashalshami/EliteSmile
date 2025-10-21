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
                              p.note,
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

                        //Crystal_Pationt report = new Crystal_Pationt();
                        //report.SetDataSource(list); // ✅ مباشرة من List<Patient>

                        //crystalReportViewer1.ReportSource = report;
                        //crystalReportViewer1.Zoom(120);
                        //crystalReportViewer1.Refresh();


                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل البيانات: " + ex.Message);
            }
        }
    }
}
