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
    public partial class BasHekimAnaEkran : Form
    {
        public BasHekimAnaEkran()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-8D5MQL0\\SQLEXPRESS; Initial Catalog = HastaneOtomasyon; Integrated Security = True");

        public string tc;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BasHekimAnaEkran_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            lblTc.Text = tc;
            //Ad soyad Çekme
            SqlCommand komut = new SqlCommand("Select BasHekimAd,BasHekimSoyad From Bashekim where BasHekimTc=@p1", baglanti);
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
            İlacEkle ilacEkle = new İlacEkle();
            ilacEkle.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DuyuruOlustur duyuru = new DuyuruOlustur();
            duyuru.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SikayetListele listele = new SikayetListele();
            listele.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PolikinlikEkle polikinlik = new PolikinlikEkle();
            polikinlik.Show();
        }
    }
}
