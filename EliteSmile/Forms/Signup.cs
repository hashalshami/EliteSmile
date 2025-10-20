using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace EliteSmile.Forms
{
    public partial class Signup : Form
    {
        private string connectionString = DatabaseInitializer.connectionString;
        public Signup()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
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

                    string sql = @"INSERT INTO Users 
                           (name, username, password, role)
                           VALUES (@name, @username, @password, @role)";

                    using (var cmd = new SQLiteCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("@role", "User");

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("✅ تم إضافة المستخدم بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء إضافة المستخدم: " + ex.Message);
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // منع الصفير الافتراضي عند الضغط على Enter
                e.SuppressKeyPress = true;

                // نقل التركيز إلى مربع النص الآخر
                txtUsername.Focus();

            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // منع الصفير الافتراضي عند الضغط على Enter
                e.SuppressKeyPress = true;

                // نقل التركيز إلى مربع النص الآخر
                txtPassword.Focus();

            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // منع الصفير الافتراضي عند الضغط على Enter
                e.SuppressKeyPress = true;
                // تشغيل حدث نقر على الزر
                addBtn.PerformClick();
            }
        }
    }
}
