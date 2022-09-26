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

        //sınıf + nesne
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CSTSJL1\\MSSQLSERVER2019;Initial Catalog=DbAkademiGrup2;Integrated Security=True");
        string sql = "Select * from TblCustomer";

        void txtBosalt()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox && item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        void listele()
        {
            SqlCommand commandL = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(commandL);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnList_Click(object sender, EventArgs e)
        {


            //string sql1 = "Select * from TblCustomer where CustomerID = '"+txtID.Text+"'  ";
            string sql1 = "Select * from TblCustomer where CustomerID = @pw1  ";



            if (txtID.Text=="")
            {
                txtBosalt();
                listele();
                //txtName.Text = "";
                //txtSurname.Text = "";
                //txtBalance.Text = "";
                //cmbCity.Text = "";


            }
            else
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql1, connection);
                command.Parameters.AddWithValue("@pw1", txtID.Text);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txtName.Text = reader["CustomerName"].ToString();
                    txtSurname.Text = reader["CustomerSurname"].ToString();
                    txtBalance.Text = reader["CustomerBalance"].ToString();
                    cmbCity.Text = reader["CustomerCity"].ToString();
                }
                connection.Close();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            connection.Open();

            SqlCommand command = new SqlCommand("insert into TblCustomer (CustomerName, CustomerSurname, CustomerCity, CustomerBalance) Values (@p1, @p2, @p3, @p4)", connection);

            command.Parameters.AddWithValue("@p1", txtName.Text);
            command.Parameters.AddWithValue("@p2", txtSurname.Text);
            command.Parameters.AddWithValue("@p3", cmbCity.Text); 
            command.Parameters.AddWithValue("@p4", txtBalance.Text);

            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Müşteri başarılı bir şekilde eklendi");
            txtBosalt();
            listele();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            connection.Open();
            SqlCommand command = new SqlCommand("Delete From TblCustomer Where CustomerID=@p1", connection);
            command.Parameters.AddWithValue("@p1", txtID.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Müşteri başarılı bir şekilde silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Question);
            txtBosalt();
            listele();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Update TblCustomer set CustomerName=@p1,CustomerSurname=@p2, CustomerCity=@p3, CustomerBalance=@p4 where CustomerID=@p5 ", connection);

            command.Parameters.AddWithValue("@p1", txtName.Text);
            command.Parameters.AddWithValue("@p2", txtSurname.Text);
            command.Parameters.AddWithValue("@p3", cmbCity.Text);
            command.Parameters.AddWithValue("@p4", Convert.ToDecimal(txtBalance.Text));
            command.Parameters.AddWithValue("@p5", txtID.Text);
            command.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Müşteri başarılı bir şekilde güncellenmiştir");
            txtBosalt();
            listele();

        }
    }
}
