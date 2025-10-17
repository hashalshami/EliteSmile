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
using EliteSmile.Models;

namespace EliteSmile
{
    public partial class Login : Form
    {
        private string connectionString = DatabaseInitializer.connectionString;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            DatabaseInitializer.Initialize();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("يرجى إدخال اسم المستخدم وكلمة المرور.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT id, name, role FROM Users WHERE username = @u AND password = @p";
                    using (var cmd = new SQLiteCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@u", username);
                        cmd.Parameters.AddWithValue("@p", password);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int userId = reader.GetInt32(0);
                                string name = reader.GetString(1);
                                string role = reader.GetString(2);

                                // حفظ بيانات المستخدم في متغيرات عامة
                                //Program.LoggedInDoctorId = userId;
                                //Program.LoggedInDoctorName = username;
                                Session.ID = userId;
                                Session.Name = name;
                                Session.Username = username;
                                Session.Password = password;
                                Session.Role = role;

                                // الانتقال إلى الشاشة الرئيسية
                                this.Hide();
                                var main = new MainForm();
                                main.Show();
                                MessageBox.Show("✅ تم تسجيل الدخول بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                            }
                            else
                            {
                                MessageBox.Show("!. اسم المستخدم أو كلمة المرور غير صحيحة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في الاتصال بقاعدة البيانات: " + ex.Message);
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
                btnLogin.PerformClick();
            }
        }
    }
}
