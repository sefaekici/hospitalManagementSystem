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
    public partial class DoktorGirisForm : Form
    {
        public DoktorGirisForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-8D5MQL0\\SQLEXPRESS; Initial Catalog = HastaneOtomasyon; Integrated Security = True");

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand command = new SqlCommand("Select *from Doktor Where DrTc=@p1 and DrSifre=@p2", baglanti);
            
            command.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            command.Parameters.AddWithValue("@p2", maskedTextBox2.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                this.Hide();
                DoktorAnaEkran anaEkran = new DoktorAnaEkran();
                anaEkran.tc = maskedTextBox1.Text;
                anaEkran.Show();
            }
            else
            {
                MessageBox.Show("Lutfen Kullanıcı Adınızı ve Şifrenizi Kontrol Ediniz...");
                maskedTextBox1.Text = "";
                maskedTextBox2.Text = "";
            }
            baglanti.Close();


        }
    }
}
