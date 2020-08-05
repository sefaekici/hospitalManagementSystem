using System;
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
    public partial class DoktorAnaEkran : Form
    {
        public DoktorAnaEkran()
        {
            InitializeComponent();
        }
        public string tc;
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-8D5MQL0\\SQLEXPRESS; Initial Catalog = HastaneOtomasyon; Integrated Security = True");
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DoktorAnaEkran_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            lblTc.Text = tc;
            //Ad soyad Çekme
            SqlCommand komut = new SqlCommand("Select DrAd,DrSoyad From Doktor where DrTc=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", lblTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " + dr[1];

            }
            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            İlacListele ilac = new İlacListele();
            ilac.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HastaListele hasta = new HastaListele();
            hasta.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RandevuListesi randevu = new RandevuListesi();
            randevu.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PolikinlikListele polikinlik = new PolikinlikListele();
            polikinlik.Show();
        }
    }
}
