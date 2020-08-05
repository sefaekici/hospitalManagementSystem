using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneOtomasyonUygulamasi
{
    public partial class HastaSikayet : Form
    {
        public HastaSikayet()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-8D5MQL0\\SQLEXPRESS; Initial Catalog = HastaneOtomasyon; Integrated Security = True");
        public string TcHasta;
        private void HastaSikayet_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            lblTc.Text = TcHasta;
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Hasta where HastaTc=@p1", baglanti);
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
            baglanti.Open();
            SqlCommand command = new SqlCommand("insert into Sikayet (SikayetMetin,HastaTc) values (@p1,@p2)", baglanti);
            command.Parameters.AddWithValue("@p1", richTextBox1.Text);
            command.Parameters.AddWithValue("@p2", lblTc.Text);
            command.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Şikayetiniz Başarıyla Gönderilmiştir...");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
