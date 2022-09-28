using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CSTSJL1\\MSSQLSERVER2019; Initial catalog=DbAkademiGrup2; integrated security=true");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from TblAdmin Where Username=@p1 and Password=@p2", connection);
            command.Parameters.AddWithValue("@p1", txtUserName.Text);
            command.Parameters.AddWithValue("@p2", txtPassword.Text);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                FrmNavigation frm = new FrmNavigation();
                frm.Show();

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
                txtPassword.UseSystemPasswordChar = true;
                chcSifreGoster.Text = "Şifreyi Göster";
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
                chcSifreGoster.Text = "Şifreyi Gizle";
            }
        }
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            sayac++;
            if (sayac==1)
            {
                txtPassword.UseSystemPasswordChar = false;
                button1.Text = "Şifreyi Gizle";
            }
            if (sayac == 2)
            {
                txtPassword.UseSystemPasswordChar = true;
                button1.Text = "Şifreyi Göster";
                sayac = 0;
            }
        }

        private void lnkHesapYokMu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmNewAccount frm = new FrmNewAccount();
            frm.Show();
        }
    }
}
