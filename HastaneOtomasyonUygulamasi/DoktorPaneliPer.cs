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
    public partial class DoktorPaneliPer : Form
    {
        public DoktorPaneliPer()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-8D5MQL0\\SQLEXPRESS; Initial Catalog = HastaneOtomasyon; Integrated Security = True");
      
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DoktorPaneliPer_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DrAd+' '+DrSoyad)as 'Doktorlar',DrBrans From Doktor", baglanti);
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Doktor (DrAd,DrSoyad,DrBrans,DrTc,DrSifre) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", DoktorKayıtAd.Text);
            komut.Parameters.AddWithValue("@p2", DoktorKayıtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", DoktorKayıtBrans.Text);
            komut.Parameters.AddWithValue("@p4", DoktorKayıtTc.Text);
            komut.Parameters.AddWithValue("@p5", DoktorKayıtSifre.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kaydınız Yapılmıştır.");
            


            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select (DrAd+' '+DrSoyad)as 'Doktorlar',DrBrans From Doktor", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
     
        }
    }
}
