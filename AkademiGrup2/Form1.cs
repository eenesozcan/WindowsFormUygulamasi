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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            //sınıf + nesne
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CSTSJL1\\MSSQLSERVER2019;Initial Catalog=DbAkademiGrup2;Integrated Security=True");

            string sql = "Select * from TblCustomer";


            if (txtID.Text=="")
            {
                SqlCommand command = new SqlCommand(sql, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();

                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            else
            {
                SqlCommand command = new SqlCommand(sql, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                
            }








        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CSTSJL1\\MSSQLSERVER2019;Initial Catalog=DbAkademiGrup2;Integrated Security=True");

            connection.Open();

            SqlCommand command = new SqlCommand("insert into TblCustomer (CustomerName, CustomerSurname, CustomerCity, CustomerBalance) Values (@p1, @p2, @p3, @p4)", connection);

            command.Parameters.AddWithValue("@p1", txtName.Text);
            command.Parameters.AddWithValue("@p2", txtSurname.Text);
            command.Parameters.AddWithValue("@p3", cmbCity.Text); 
            command.Parameters.AddWithValue("@p4", txtBalance.Text);

            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Müşteri başarılı bir şekilde eklendi");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CSTSJL1\\MSSQLSERVER2019;Initial Catalog=DbAkademiGrup2;Integrated Security=True");

            connection.Open();
            SqlCommand command = new SqlCommand("Delete From TblCustomer Where CustomerID=@p1", connection);
            command.Parameters.AddWithValue("@p1", txtID.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Müşteri başarılı bir şekilde silindi");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CSTSJL1\\MSSQLSERVER2019;Initial Catalog=DbAkademiGrup2;Integrated Security=True");

            connection.Open();
            SqlCommand command = new SqlCommand("Update TblCustomer set CustomerName=@p1,CustomerSurname=@p2, CustomerCity=@p3, CustomerBalance=@p4 where CustomerID=@p5 ", connection);

            command.Parameters.AddWithValue("@p1", txtName.Text);
            command.Parameters.AddWithValue("@p2", txtSurname.Text);
            command.Parameters.AddWithValue("@p3", cmbCity.Text);
            command.Parameters.AddWithValue("@p4", txtBalance.Text);
            command.Parameters.AddWithValue("@p5", txtID.Text);
            command.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Müşteri başarılı bir şekilde güncellenmiştir");
        }
    }
}
