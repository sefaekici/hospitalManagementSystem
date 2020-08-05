﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneOtomasyonUygulamasi
{
    public partial class HastaListele : Form
    {
        public HastaListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-8D5MQL0\\SQLEXPRESS; Initial Catalog = HastaneOtomasyon; Integrated Security = True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void HastaListele_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Hasta", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
    }
}
