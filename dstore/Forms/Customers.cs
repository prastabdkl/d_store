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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Height = 400;
            this.Width = 300;
        }

        private void addcustomerButton_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=ahnupsingh;password=Startwithme-55";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlDataReader myReader;
            string Query = "insert into Departmentalstore.customer (Customer_ID, Name, Address, Phone_No, Type) values('" + this.Customer_ID_txt.Text + "', '" + this.name_txt.Text + "' , '" + this.Address_txt.Text + "', '" + this.Phone_txt.Text + "', '" + this.comboBox1.Text + "' );";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MessageBox.Show("Saved");
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchCustomer_Click(object sender, EventArgs e)
        {
            this.Width = 805;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=ahnupsingh;password=Startwithme-55";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlDataReader myReader;
            string Query;
            if (SearchName.Text != null)
            {
                try
                {
                    Query = "select * from departmentalstore.Customer where Name = '" + this.SearchName.Text + "'";
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();
                    if ((string)myReader.GetValue(myReader.GetOrdinal("Type")) == "Online")
                    {
                        DataTable dt = new DataTable();
                        dt.Load(myReader);
                        instoreCustomerGridView.DataSource = dt;
                    }
                    else
                    {
                        DataTable dt = new DataTable();
                        dt.Load(myReader);
                        onlineCustomerGridView.DataSource = dt;
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conDataBase.Close();
                }
            }

            else if (SearchAddress != null)
            {
                try
                {
                    Query = "select Customer_Id, Name, Address, Phone_No from departmentalstore.Customer where Address = '" + this.SearchAddress.Text + "'";
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();
                    if (myReader.HasRows)
                    {
                        if ((string)myReader.GetValue(myReader.GetOrdinal("Type")) == "Online")
                        {
                            DataTable dt = new DataTable();
                            dt.Load(myReader);
                            instoreCustomerGridView.DataSource = dt;
                        }
                        else
                        {
                            DataTable dt = new DataTable();
                            dt.Load(myReader);
                            onlineCustomerGridView.DataSource = dt;
                        }
                        Console.WriteLine("Searched");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conDataBase.Close();
                }
            }
            else if ((SearchName.Text == null && SearchAddress.Text == null) || (SearchName.Text != null && SearchAddress.Text != null))
            {
                MessageBox.Show("Nothing to Search");
            }
        }

        private void TabControl1_SelectedIndexChanged(Object sender, EventArgs e)
        {

            MessageBox.Show("You are in the TabControl.SelectedIndexChanged event.");

        }

    }
}
