using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneOtomasyonUygulamasi
{
    public partial class HemşireAnaForm : Form
    {
        public HemşireAnaForm()
        {
            InitializeComponent();
        }
        public string tc;
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-8D5MQL0\\SQLEXPRESS; Initial Catalog = HastaneOtomasyon; Integrated Security = True");

        private void HemşireAnaForm_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            lblTc.Text = tc;
            //Ad soyad Çekme
            SqlCommand komut = new SqlCommand("Select HemsireAd,HemsireSoyad From Hemsire where HemsireTc=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", lblTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " + dr[1];

            }
            baglanti.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            İlacEkle ilacEkle = new İlacEkle();
            ilacEkle.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PerDuyuru perDuyuru = new PerDuyuru();
            perDuyuru.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PolikinlikEkle polikinlik = new PolikinlikEkle();
            polikinlik.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SikayetListele listele = new SikayetListele();
            listele.Show();
        }
    }
}
