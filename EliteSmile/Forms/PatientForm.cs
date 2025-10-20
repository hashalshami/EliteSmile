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
using System.IO;
using EliteSmile.Models;
using EliteSmile.Classes;

namespace EliteSmile.Forms
{
    public partial class PatientForm : Form
    {
        private string connectionString = DatabaseInitializer.connectionString;

        private void ClearFields()
        {
            txtID.Text = "";
            txtDoctorName.Text = Session.Name;
            dateTimePicker1.Value = DateTime.Now;
            txtName.Text = "";
            txtFileNo.Text = "";
            txtPhone.Text = "";
            txtPlan.Text = "";
            txtNote.Text = "";
            dataGridView1.CellPainting -= dataGridView1_CellPainting;
        }
        private void LoadPatients()
        {
            try
            {
                var patients = new List<Patient>();

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT p.*, u.Name AS DoctorName " +
                                 "FROM Patients p " +
                                 "LEFT JOIN Users u ON p.DoctorId = u.Id " +
                                 "WHERE p.DoctorId = @DoctorId " +
                                 "ORDER BY p.Id DESC";

                    using (var cmd = new SQLiteCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@DoctorId", 1);

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
                                    DoctorId = reader.IsDBNull(4) ? 0 : reader.GetInt32(4),
                                    Date = reader.IsDBNull(5) ? "" : reader.GetString(5),
                                    TreatmentPlan = reader.IsDBNull(6) ? "" : reader.GetString(6),
                                    DoctorName = reader.IsDBNull(7) ? "" : reader.GetString(7),
                                });
                            }
                        }
                    }
                }

                dataGridView1.DataSource = patients;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ عند الاتصال: " + ex.Message);
            }
        }
        
        private void LoadData()
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string sql = @"SELECT 
                                      p.id,
                                      p.name,
                                      p.fileNo,
                                      p.note,
                                      p.plan,
                                      p.phone,
                                      p.date,
                                      u.name AS DoctorName
                                   FROM Patients p
                                   LEFT JOIN Users u ON p.DoctorId = u.id
                                   WHERE p.DoctorId = @DoctorId
                                   ORDER BY p.id DESC";

                    using (var adapter = new SQLiteDataAdapter(sql, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@DoctorId", Session.ID);

                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView1.DataSource = dt;

                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل البيانات: " + ex.Message);
            }
        }

        
        public PatientForm()
        {
            InitializeComponent();
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            DatabaseInitializer.Initialize();
            dataGridView1.RowPrePaint += MasterClass.ApplyRowStyle;
            
            ClearFields();
            txtName.Focus();
            LoadData();
        }
        
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(txtPlan.Text))
            {
                MessageBox.Show("يرجى ملء جميع الحقول!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string sql = @"INSERT INTO Patients 
                           (name, phone, fileNo, date, plan, note, DoctorId)
                           VALUES (@name, @phone, @fileNo, @date, @plan, @note, @DoctorId)";

                    using (var cmd = new SQLiteCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@fileNo", txtFileNo.Text);
                        cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@plan", txtPlan.Text);
                        cmd.Parameters.AddWithValue("@note", txtNote.Text);
                        cmd.Parameters.AddWithValue("@DoctorId", Session.ID);

                        cmd.ExecuteNonQuery();
                    }
                    LoadData();
                    MessageBox.Show("✅ تم إضافة المريض بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء إضافة المريض: " + ex.Message);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("الرجاء تحديد مريض للتعديل.", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int patient_id = Convert.ToInt32(txtID.Text);

            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string sql = @"UPDATE Patients 
                                   SET name = @name, phone = @phone, fileNo = @fileNo, date = @date, plan = @plan, note = @note
                                   WHERE id = @id";

                    using (var cmd = new SQLiteCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(patient_id));
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@fileNo", txtFileNo.Text);
                        cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@plan", txtPlan.Text);
                        cmd.Parameters.AddWithValue("@note", txtNote.Text);

                        cmd.ExecuteNonQuery();
                    }

                    LoadData();
                    MessageBox.Show("✅ تم تعديل بيانات المريض بنجاح!");
                    ClearFields();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ أثناء التعديل: " + ex.Message);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("الرجاء تحديد مريض للحذف.", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int patient_id = Convert.ToInt32(txtID.Text);

            if (MessageBox.Show("هل أنت متأكد من حذف هذا المريض؟", "تأكيد", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string sql = "DELETE FROM Patients WHERE id = @id";

                    using (var cmd = new SQLiteCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", patient_id);
                        cmd.ExecuteNonQuery();
                    }
                    LoadData();
                    MessageBox.Show("🗑️ تم حذف المريض بنجاح!");
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ أثناء الحذف: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtID.Text = row.Cells["colID"].Value != null ? row.Cells["colID"].Value.ToString() : "";
                txtName.Text = row.Cells["colName"].Value != null ? row.Cells["colName"].Value.ToString() : "";
                txtPhone.Text = row.Cells["colPhone"].Value != null ? row.Cells["colPhone"].Value.ToString() : "";
                txtFileNo.Text = row.Cells["colFileNo"].Value != null ? row.Cells["colFileNo"].Value.ToString() : "";
                dateTimePicker1.Value = row.Cells["colDate"].Value != null ? Convert.ToDateTime(row.Cells["colDate"].Value) : DateTime.Now;
                txtPlan.Text = row.Cells["colPlan"].Value != null ? row.Cells["colPlan"].Value.ToString() : "";
                txtNote.Text = row.Cells["colNote"].Value != null ? row.Cells["colNote"].Value.ToString() : "";
                
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
            LoadData();
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                MasterClass.DataGrid_CellPainting(dataGridView1, e, txtName.Text, "colName", txtName, isRightToLeft: true);
            }
            //MasterClass.DataGrid_CellPainting(dataGridView1, e, txtName.Text, "colName", txtName, isRightToLeft: true);
            
        }

        private void searchName(string text)
        {
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string sql = @"SELECT 
                                      p.id,
                                      p.name,
                                      p.fileNo,
                                      p.note,
                                      p.plan,
                                      p.phone,
                                      p.date,
                                      u.name AS DoctorName
                                   FROM Patients p
                                   LEFT JOIN Users u ON p.DoctorId = u.id
                                   WHERE p.name LIKE @name
                                   ORDER BY p.id DESC";

                    using (var adapter = new SQLiteDataAdapter(sql, connection))
                    {
                        //adapter.SelectCommand.Parameters.AddWithValue("@DoctorId", Session.ID);
                        adapter.SelectCommand.Parameters.AddWithValue("@name", "%" + text + "%");

                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView1.DataSource = dt;

                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ أثناء البحث: " + ex.Message);
                return;
            }
        }
        

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                return;
            }
            
            searchName(txtName.Text);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
            //if (string.IsNullOrWhiteSpace(txtName.Text))
            //{
                //return;
            //}
            //searchName(txtName.Text);
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                searchName(txtName.Text);
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                return;
            }
            
            if (e.KeyCode == Keys.Enter)
            {
                // منع الصفير الافتراضي عند الضغط على Enter
                e.SuppressKeyPress = true;
                searchName(txtName.Text);
                // نقل التركيز إلى مربع النص الآخر
                txtFileNo.Focus();

            }
        }

        private void txtFileNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // منع الصفير الافتراضي عند الضغط على Enter
                e.SuppressKeyPress = true;

                txtNote.Focus();
            }
        }

        private void txtNote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // منع الصفير الافتراضي عند الضغط على Enter
                e.SuppressKeyPress = true;

                txtPhone.Focus();
            }
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // منع الصفير الافتراضي عند الضغط على Enter
                e.SuppressKeyPress = true;

                // نقل التركيز إلى مربع النص الآخر
                txtPlan.Focus();

            }
        }

        private void txtPlan_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    e.SuppressKeyPress = true;

            //    txtPlan.Focus();

            //}
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("يرجى تحديد المريض لطباعة الخطة !", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int patient_id = Convert.ToInt32(txtID.Text);
            PatientReportForm report = new PatientReportForm(patient_id);
            report.Show();
            //report.ShowDialog();
        }

        

        
    }
}
