using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EliteSmile.Data;
using EliteSmile.Models;

namespace EliteSmile
{
    public partial class Form1 : Form
    {
        private PatientRepository repo = new PatientRepository();
        private string connString = DatabaseInitializer.connectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DatabaseInitializer.Initialize();
            LoadPatients();
        }

        private void LoadPatients()
        {
            var patients = repo.GetAll();
            dataGridView1.DataSource = patients;
        }


    }
}
