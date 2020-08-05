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
    public partial class PersonelAnaEkran : Form
    {
        public PersonelAnaEkran()
        {
            InitializeComponent();
        }
        public string Tc;
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-8D5MQL0\\SQLEXPRESS; Initial Catalog = HastaneOtomasyon; Integrated Security = True");
        private void personelGeribtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Personel personel = new Personel();
            personel.Show();
        }

        private void PersonelAnaEkran_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            label3.Text = Tc;
            SqlCommand komut = new SqlCommand("Select PersonelAd,PersonelSoyad From Personel where PersonelTc=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", label3.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " + dr[1];

            }
            baglanti.Close();
            //Branşları Data Gride Aktarma 
            baglanti.Open();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select *from Brans",baglanti);
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            baglanti.Close();

            //Doktorları listeye aktarma 
            baglanti.Open();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DrAd+' '+DrSoyad)as 'Doktorlar',DrBrans From Doktor", baglanti);
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            baglanti.Close();

            //Branşı Comboxa Aktarma 
            baglanti.Open();
            SqlCommand KomutCombo = new SqlCommand("Select BransAd from Brans",baglanti);
            SqlDataReader okuyucu = KomutCombo.ExecuteReader();
            while (okuyucu.Read())
            {
                comboBrans.Items.Add(okuyucu[0]);
            }
            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Tabloya Randevu Ekleme
            baglanti.Open();
            SqlCommand komutkaydet = new SqlCommand("insert into RandevuHasta (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor,RandevuDurum) values (@r1,@r2,@r3,@r4,@r5) ",baglanti);
            komutkaydet.Parameters.AddWithValue("@r1",mskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2",mskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3",comboBrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4",comboDoktor.Text);
            if (checkDurum.Checked == true)
            {
                komutkaydet.Parameters.AddWithValue("@r5",true);
            }
            else
            {
                komutkaydet.Parameters.AddWithValue("@r5", false);
            }
            
            komutkaydet.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaydiniz Olusturuldu...");

        }

        private void comboBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Combo Box Doktor Gösterme 

            comboDoktor.Items.Clear();
            baglanti.Open();
            SqlCommand comboCommand = new SqlCommand("Select DrAd,DrSoyad from Doktor where DrBrans=@p1",baglanti);
            comboCommand.Parameters.AddWithValue("@p1", comboBrans.Text);
            SqlDataReader dr1 = comboCommand.ExecuteReader();
            while (dr1.Read())
            {
                comboDoktor.Items.Add(dr1[0]+" "+dr1[1]);
            }



            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand command = new SqlCommand("insert into Duyuru(DuyuruMetin)values (@d1)",baglanti);
            command.Parameters.AddWithValue("@d1", richTextBox1.Text);
            command.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Duyuru Oluşturuldu...");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoktorPaneliPer doktor = new DoktorPaneliPer();
            doktor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BransPer brans = new BransPer();
            brans.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RandevuListesi randevu = new RandevuListesi();
            randevu.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PerDuyuru perDuyuru = new PerDuyuru();
            perDuyuru.Show();
        }
    }
}
