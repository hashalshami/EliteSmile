using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EliteSmile.Models;

namespace EliteSmile
{
    public partial class Form1 : Form
    {
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
            //dataGridView1.DataSource = patients;
        }


    }
}
