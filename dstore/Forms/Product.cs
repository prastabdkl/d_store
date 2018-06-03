using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace dstore.Forms
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Height = 400;
            this.Width = 300;
        }
        private void addProductButton_Click(object sender, EventArgs e)
        {
            MySqlConnection conDataBase = new MySqlConnection(LoginForm.constring);
            MySqlDataReader myReader;
            string Query = "insert into Departmentalstore.product_table (Product_ID, Product_Name, Category, Manufacturer, Price) values('" + this.Product_ID.Text + "', '" + this.Product_name.Text + "' , '" + this.Category.Text + "', '" + this.Manufacturer.Text + "', '" + this.Price.Text + "' );";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MessageBox.Show("Saved");
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {

                }
                conDataBase.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchProduct_Click(object sender, EventArgs e)
        {
            this.Width = 805;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            MySqlConnection conDataBase = new MySqlConnection(LoginForm.constring);
            MySqlDataReader myReader;
            try
            {
                string Query = "select * from departmentalstore.product_table where Product_Name = '" + this.SearchName.Text + "'";
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                if (myReader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(myReader);
                    productGridView1.DataSource = dt;
                    Console.WriteLine("Searched");
                    conDataBase.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conDataBase.Close();
            }
        }
    }
}
