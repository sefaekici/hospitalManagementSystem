using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneOtomasyonUygulamasi
{
    public partial class DuyuruOlustur : Form
    {
        public DuyuruOlustur()
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
            SqlCommand command = new SqlCommand("insert into BasHekimDuyuru (BasHekimDuyuruMetin) values (@p1)", baglanti);
            command.Parameters.AddWithValue("@p1", richTextBox1.Text);
            command.ExecuteNonQuery();
            baglanti.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
