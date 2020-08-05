using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonUygulamasi
{
    public partial class DoktorForm : Form
    {
        public DoktorForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoktorGirisForm doktorGiris = new DoktorGirisForm();
            doktorGiris.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BashekimGirisForm bashekimGiris = new BashekimGirisForm();
            bashekimGiris.Show();
        }
    }
}
