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
    public partial class ConfigProduct : Form
    {
        public ConfigProduct()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
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
                }
                conDataBase.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                conDataBase.Close();
            }
        }

        private void productGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.productGridView1.Rows[e.RowIndex];
                Product_ID.Text = row.Cells["Product_ID"].Value.ToString();
                Product_Name.Text = row.Cells["Product_Name"].Value.ToString();
                Category.Text = row.Cells["Category"].Value.ToString();
                Manufacturer.Text = row.Cells["Manufacturer"].Value.ToString();
                Price.Text = row.Cells["Price"].Value.ToString();

            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            MySqlConnection conDataBase = new MySqlConnection(LoginForm.constring);
            MySqlDataReader myReader;
            try
            {
          
                string Query = "select * from departmentalstore.product_table where Product_Name = '" + this.Product_Name.Text + "'";
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                if (myReader.HasRows)
                {
                    try
                    {
                        string Query1 = "delete from departmentalstore.product_table where Product_Name = '" + this.Product_Name.Text + "';";
                        MySqlCommand cmdDataBase1 = new MySqlCommand(Query, conDataBase);
                        MessageBox.Show("Deleted");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        conDataBase.Close();
                    }
        
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                conDataBase.Close();
            }
        }

        private void UpdateProduct_Click(object sender, EventArgs e)
        {
            MySqlConnection conDataBase = new MySqlConnection(LoginForm.constring);
            MySqlDataReader myReader;
            MySqlCommandBuilder cmdBuilder;

            DataSet ProductsDataSet = new DataSet();
            MySqlDataAdapter da;

            
            //Set the connection string of the SqlConnection object to connect to the SQL Server

            conDataBase.Open();

            //Initialize the SqlDataAdapter object by specifying a Select command 
            //that retrieves data from the sample table.
            da = new MySqlDataAdapter("select * from departmentalstore.product_table where Product_ID = '"+this.Product_ID.Text+"'", conDataBase);

            //Initialize the SqlCommandBuilder object to automatically generate and initialize
            //the UpdateCommand, InsertCommand, and DeleteCommand properties of the SqlDataAdapter.
            cmdBuilder = new MySqlCommandBuilder(da);

            //Populate the DataSet by running the Fill method of the SqlDataAdapter.
            da.Fill(ProductsDataSet, "Products");

            //Modify the value 
            ProductsDataSet.Tables["Products"].Rows[0]["Product_Name"] = this.Product_Name.Text;
            ProductsDataSet.Tables["Products"].Rows[0]["Category"] = this.Category.Text;
            ProductsDataSet.Tables["Products"].Rows[0]["Manufacturer"] = this.Manufacturer.Text;
            ProductsDataSet.Tables["Products"].Rows[0]["Price"] = this.Price.Text;

            //Post the data modification to the database.
            try
            {
                da.Update(ProductsDataSet, "Products");
                MessageBox.Show("The selected product has been updated successfully");

                //Close the database connection.
                conDataBase.Close();

                //Pause
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conDataBase.Close();
            }
            


            try
            {
                string Query = "select * from departmentalstore.product_table where Product_ID = '" + this.Product_ID.Text + "'";
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                conDataBase.Close();
            }
        }
    }
}
