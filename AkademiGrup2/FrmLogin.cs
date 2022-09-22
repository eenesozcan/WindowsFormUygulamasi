using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkademiGrup2
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="admin" && textBox2.Text=="1234")
            {
                MessageBox.Show("yes");
            }
            else
            {
                MessageBox.Show("no");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Yönlendiriliyorsunuz...");
        }

        private void chcSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chcSifreGoster.Checked==true)
            {
                textBox2.UseSystemPasswordChar = true;
                chcSifreGoster.Text = "Şifreyi Göster";
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
                chcSifreGoster.Text = "Şifreyi Gizle";
            }
        }
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            sayac++;
            if (sayac==1)
            {
                textBox2.UseSystemPasswordChar = false;
                button1.Text = "Şifreyi Gizle";
            }
            if (sayac == 2)
            {
                textBox2.UseSystemPasswordChar = true;
                button1.Text = "Şifreyi Göster";
                sayac = 0;
            }
        }
    }
}
