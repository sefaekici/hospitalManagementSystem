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
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-8D5MQL0\\SQLEXPRESS; Initial Catalog = HastaneOtomasyon; Integrated Security = True");
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PersonelGirisbtn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select* From Personel where PersonelTc=@p1 and PersonelSifre=@p2",baglanti);
            baglanti.Open();
            command.Parameters.AddWithValue("@p1", PersonelTcmasked.Text);
            command.Parameters.AddWithValue("@p2", PersonelSifremasked.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                this.Hide();
                PersonelAnaEkran anaEkran = new PersonelAnaEkran();
                anaEkran.Tc = PersonelTcmasked.Text;
                
                anaEkran.Show();
            }
            else
            {
                MessageBox.Show("Lutfen Kullanıcı Adınızı ve Şifrenizi Kontrol Ediniz...");
                PersonelSifremasked.Text = "";
                PersonelSifremasked.Text = "";
            }
            baglanti.Close();
        }
    }
}
