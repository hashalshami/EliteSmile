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

namespace EliteSmile.Forms
{
    public partial class ProfileForm : Form
    {
        private string connectionString = DatabaseInitializer.connectionString;
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            txtName.Text = Session.Name;
            txtUsername.Text = Session.Username;
            txtPassword.Text = Session.Password;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("يرجى ملء جميع الحقول!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE Users SET name = @Name, username = @Username, password = @Password WHERE id = @Id";
                    using (var cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", txtName.Text);
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("@Id", Session.ID);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("تم تحديث بياناتك بنجاح ✅", "تحديث", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // تحديث الجلسة الحالية
                            Session.Name = txtName.Text;
                            Session.Username = txtUsername.Text;
                            Session.Password = txtPassword.Text;
                        }
                        else
                        {
                            MessageBox.Show("حدث خطأ أثناء التحديث!", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ عند تحديث البيانات: " + ex.Message);
            }
        }
    }
}
