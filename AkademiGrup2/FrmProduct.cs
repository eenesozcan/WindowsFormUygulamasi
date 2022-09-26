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
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-CSTSJL1\MSSQLSERVER2019;Initial Catalog=DbAkademiGrup2;integrated security=True");

        private void btnList_Click(object sender, EventArgs e)
        {
            //dosya yolu öncesi \\ koymak gerekiyor (DESKTOP-CSTSJL1\\MSSQLSERVER2019 yada en başa @

            SqlCommand command=new SqlCommand("Select * from TblProduct inner join TblCategory TC on  TC.categoryId=TblProduct.ProductCategory", connection);

            SqlDataAdapter adapter =new SqlDataAdapter(command);

            DataTable dt=new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand command = new SqlCommand("insert into TblProduct (ProductName, ProductStock, ProductPrice, ProductCategory) values (@p1,@p2,@p3,@p4)", connection);

            command.Parameters.AddWithValue("@p1", txtProductName.Text);
            command.Parameters.AddWithValue("@p2", txtProductStock.Text);
            command.Parameters.AddWithValue("@p3", txtProductPrice.Text);
            command.Parameters.AddWithValue("@p4", txtProductCategory.Text);
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Ürün başarılı bir şekilde eklendi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductID=@p1 ", connection);
            command.Parameters.AddWithValue("@p1", txtProductID.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Ürün başarılı bir şekilde silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Question);
            connection.Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@p1 where ProductID=@p2", connection);
            command.Parameters.AddWithValue("@p1", txtProductName.Text);
            command.Parameters.AddWithValue("@p2", txtProductID.Text);
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Ürün başarılı bir şekilde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
