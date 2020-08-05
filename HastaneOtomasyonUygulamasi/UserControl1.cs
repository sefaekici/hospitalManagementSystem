using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneOtomasyonUygulamasi
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DoktorForm doktorForm = new DoktorForm();
            doktorForm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            HemsireForm hemsireForm = new HemsireForm();
            hemsireForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            HastaForm hastaForm = new HastaForm();
            hastaForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            Personel personelForm = new Personel();
            personelForm.Show();
            
        }
    }
}
