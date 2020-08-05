using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneOtomasyonUygulamasi
{
    public partial class HastaKayitForm : Form
    {
        public HastaKayitForm()
        {
            InitializeComponent();
        }
        bool Durum;
        SqlConnection baglanti=new SqlConnection("Data Source = DESKTOP-8D5MQL0\\SQLEXPRESS; Initial Catalog = HastaneOtomasyon; Integrated Security = True");

        void Mukerrer()
        {
            
            SqlCommand komut = new SqlCommand("select *from Hasta where HastaTc=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1", HastaKayıtTc.Text);
            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                Durum = false;                
            }
            else
            {
                Durum = true;
                
            }
            baglanti.Close();

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Hasta (HastaAd,HastaSoyad,HastaTc,HastaSifre) values (@p1,@p2,@p3,@p4)",baglanti);
            Mukerrer();
            if(HastaKayıtAd.Text == "" || HastaKayıtSifre.Text == "" || HastaKayıtSoyad.Text == "" || HastaKayıtTc.Text == "" || Durum==false)
            {
                if (HastaKayıtAd.Text == "" || HastaKayıtSifre.Text == "" || HastaKayıtSoyad.Text == "" || HastaKayıtTc.Text == "")
                {
                    MessageBox.Show("Lutfen boş alanları doldurunuz...");
                }
                if (Durum == false)
                {
                    MessageBox.Show("Aynı TC kimlik numarasına sahip kayıt bulunmaktadır.Lütfen kimlik numaranızı kontrol ediniz.");
                }
            }
            else 
            {
                baglanti.Open();
                komut.Parameters.AddWithValue("@p1", HastaKayıtAd.Text);
                komut.Parameters.AddWithValue("@p2", HastaKayıtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", HastaKayıtTc.Text);
                komut.Parameters.AddWithValue("@p4", HastaKayıtSifre.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kaydınız Yapılmıştır.");
            }
            

            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HastaForm hastaForm = new HastaForm();
            this.Hide();
            hastaForm.Show();
        }

        private void temizlebtn_Click(object sender, EventArgs e)
        {
            HastaKayıtAd.Text = "";
            HastaKayıtSifre.Text = "";
            HastaKayıtSoyad.Text = "";
            HastaKayıtTc.Text = "";
        }
    }
}
