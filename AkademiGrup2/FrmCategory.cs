using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AkademiGrup2
{
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CSTSJL1\\MSSQLSERVER2019; Initial catalog=DbAkademiGrup2; integrated security=true");

        private void btnList_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand command = new SqlCommand("Select * from TblCategory", connection);
            SqlDataAdapter adapter= new SqlDataAdapter(command);    
            DataTable dt= new DataTable();

            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);


            command.Parameters.AddWithValue("@p1", txtName.Text);

            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Kategori başarılı bir şekilde eklendi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand command = new SqlCommand("Delete From TblCategory Where CategoryID=@p1 ", connection);
            command.Parameters.AddWithValue("@p1", txtID.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kategori başarılı bir şekilde silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Question);
            connection.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Update TblCategory Set ProductName=@p1 where CategoryID=@p2", connection);
            command.Parameters.AddWithValue("@p1", txtName.Text);
            command.Parameters.AddWithValue("@p2", txtID.Text);
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Kategori başarılı bir şekilde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from TblCategory- where ProductName like 'a%'",connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();

            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from TblCategory- where ProductName like '%a'", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();

            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnCreatCode_Click(object sender, EventArgs e)
        {
            //ABCDEFGH
            //1234567890

            //AAA00
            string[] harfler ={"A","B","C","D","E","F","G","H" };

            Random rnd= new Random();
            //int sayi = rnd.Next(0,10);
            //txtCode.Text = sayi.ToString();

            //int sayi = rnd.Next(0,8);
            //txtCode.Text = harfler[sayi];

            int sayi = rnd.Next(0, 8);
            int sayi2= rnd.Next(0, 8);
            int sayi3= rnd.Next(0, harfler.Length);
            int sayi4= rnd.Next(0, 10);
            int sayi5= rnd.Next(0, 10);

            txtCode.Text = harfler[sayi] + harfler[sayi2] + harfler[sayi3] + sayi4 + sayi5;


        }



        private void btnQR_Click(object sender, EventArgs e)
        {
            string str = txtCode.Text;
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(str, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            imgQRCode.Image = qrCodeImage;


            //using (MemoryStream ms = new MemoryStream())
            //{
            //    QRCodeGenerator koduret = new QRCodeGenerator();
            //    QRCodeGenerator.QRCode kod = koduret.CreateQrCode(txtCode.Text, QRCodeGenerator.ECCLevel.Q);
            //    using (Bitmap bmp = kod.GetGraphic(5))
            //    {
            //        bmp.Save(ms, ImageFormat.Png);
            //        img_yeri.ImageUrl = "data:imge/png;base64," + Convert.ToBase64String(ms.ToArray());
            //    }
            //}
        }
    }
}
