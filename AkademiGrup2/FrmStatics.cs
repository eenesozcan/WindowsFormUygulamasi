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
    public partial class FrmStatics : Form
    {
        public FrmStatics()
        {
            InitializeComponent();
        }

        private void FrmStatics_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CSTSJL1\\MSSQLSERVER2019; Initial catalog=DbAkademiGrup2; integrated security=true");

            connection.Open();
            SqlCommand command1 = new SqlCommand("Select count(*) From TblCategory", connection);
            SqlDataReader reader=command1.ExecuteReader();
            while (reader.Read())
            {
                lblCategoryCount.Text = reader[0].ToString();
            }
            connection.Close();

            connection.Open();
            SqlCommand command2 = new SqlCommand("Select count(*) From TblProduct", connection);
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                lblProductCount.Text = reader2[0].ToString();
            }
            connection.Close();

            connection.Open();
            SqlCommand command3 = new SqlCommand("Select count(Distinct(CustomerCity)) From TblCustomer", connection);
            SqlDataReader reader3 = command3.ExecuteReader();
            while (reader3.Read())
            {
                lblPCityCount.Text = reader3[0].ToString();
            }
            connection.Close();

            connection.Open();
            SqlCommand command4 = new SqlCommand("Select sum(ProductStock) From TblProduct", connection);
            SqlDataReader reader4 = command4.ExecuteReader();
            while (reader4.Read())
            {
                lblStockCount.Text = reader4[0].ToString();
            }
            connection.Close();

            connection.Open();
            SqlCommand command5 = new SqlCommand("Select ProductName From TblProduct where ProductStock=(Select Max(ProductStock) From TblProduct)", connection);
            SqlDataReader reader5 = command5.ExecuteReader();
            while (reader5.Read())
            {
                lblMaxCount.Text = reader5[0].ToString();
            }
            connection.Close();
        }
    }
}
