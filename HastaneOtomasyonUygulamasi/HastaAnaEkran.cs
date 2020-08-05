using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneOtomasyonUygulamasi
{
    public partial class HastaAnaEkran : Form
    {
        public string tc;
        public HastaAnaEkran()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-8D5MQL0\\SQLEXPRESS; Initial Catalog = HastaneOtomasyon; Integrated Security = True");
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HastaForm hasta = new HastaForm();
            hasta.Show();
        }
        
        private void HastaAnaEkran_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            lblTc.Text = tc;
            //Ad soyad Çekme
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Hasta where HastaTc=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1",lblTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " + dr[1];

            }
            baglanti.Close();
            //Randevu Geçmişi
            baglanti.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select *From RandevuHasta where HastaTc=" + tc, baglanti);
            da.Fill(dt);
            dataGridView1.DataSource=dt;
            baglanti.Close();

            //Branşları Çek
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select BransAd From Brans",baglanti);
            SqlDataReader dr1 = komut2.ExecuteReader();
            while (dr1.Read())
            {
                bransCombo.Items.Add(dr1[0]);
            }
            baglanti.Close();

        }

        private void bransCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //doktor listesi olustur(bransa özel)
            //Liste tekrar tekrar temizlenmelidir.
            doktorCombo.Items.Clear();
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select DrAd,DrSoyad From Doktor where DrBrans=@p1",baglanti);
            komut3.Parameters.AddWithValue("@p1",bransCombo.Text);
            SqlDataReader dr2 = komut3.ExecuteReader();
            while (dr2.Read())
            {
                doktorCombo.Items.Add(dr2[0] + "" + dr2[1]);
            }
            baglanti.Close();
        }

        private void doktorCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select *From RandevuHasta where RandevuBrans='" + bransCombo.Text + "'", baglanti);
            da.Fill(dt1);
            dataGridView2.DataSource = dt1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HastaSikayet sikayet = new HastaSikayet();
            sikayet.TcHasta = tc;
            sikayet.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
