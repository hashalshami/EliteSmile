using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EliteSmile.Forms;
using EliteSmile.Models;
using EliteSmile.Classes;

namespace EliteSmile
{
    public partial class MainForm : Form
    {
        public void OpenChildForm(Form childForm)
        {
            if (panelContainer.Controls.Count > 0)
                panelContainer.Controls.RemoveAt(0);
            titleLabel.Text = childForm.Text;
            this.Text = childForm.Text;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            this.Refresh();
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MasterClass.ResizeToolStripMenuItemImageByHeight(UserMenuItem, 25);
            MasterClass.ResizeToolStripMenuItemImageByHeight(PlanMenuItem, 25);
            MasterClass.ResizeToolStripMenuItemImageByHeight(EliteSmileMenuItem, 30);

            //Session.ID = 1;
            //Session.Name = "د. هند امين";
            //Session.Username = "hashem";
            //Session.Password = "1234";
            //Session.Role = "Doctor";

            UserMenuItem.Text = Session.Name;

            OpenChildForm(new PatientForm());

        }

        private void LogoutMenuItem_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("هل تريد تسجيل الخروج؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                // 🧹 مسح بيانات الجلسة
                Session.ID = 0;
                Session.Name = null;
                Session.Username = null;
                Session.Password = null;
                Session.Role = null;

                // العودة إلى شاشة تسجيل الدخول
                this.Hide();
                var login = new Login();
                MessageBox.Show("✅ تم تسجيل الخروج بنجاح!", "نجاح");
                login.Show();
            }
        }

        private void ProfileMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProfileForm());
        }

        private void PlanMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PatientForm());
        }
    }
}
