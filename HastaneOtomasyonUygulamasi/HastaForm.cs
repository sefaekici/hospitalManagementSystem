using System;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace HastaneOtomasyonUygulamasi
{
    public partial class HastaForm : Form
    {
        public HastaForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-8D5MQL0\\SQLEXPRESS; Initial Catalog = HastaneOtomasyon; Integrated Security = True");

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select *from Hasta Where HastaTc=@p1 and HastaSifre=@p2",baglanti);
            baglanti.Open();
            command.Parameters.AddWithValue("@p1",hastaTc.Text);
            command.Parameters.AddWithValue("@p2", hastaSifre.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                this.Hide();
                HastaAnaEkran anaEkran = new HastaAnaEkran();
                anaEkran.tc = hastaTc.Text;
                anaEkran.Show();
            }
            else
            {
                MessageBox.Show("Lutfen Kullanıcı Adınızı ve Şifrenizi Kontrol Ediniz...");
                hastaTc.Text = "";
                hastaSifre.Text = "";
            }
            baglanti.Close();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HastaKayitForm hastaKayit = new HastaKayitForm();
            hastaKayit.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void HastaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
