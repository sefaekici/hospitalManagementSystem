using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace HastaneOtomasyonUygulamasi
{
    public partial class PerDuyuru : Form
    {
        public PerDuyuru()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-8D5MQL0\\SQLEXPRESS; Initial Catalog = HastaneOtomasyon; Integrated Security = True");


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PerDuyuru_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Duyuru",baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
    }
}
