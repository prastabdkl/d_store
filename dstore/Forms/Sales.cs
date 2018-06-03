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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
            MessageBox.Show(LoginForm.x);
            //MessageBox.Show(user);
            this.Width = 972;
            search_by.Items.Add("Product Code");
            search_by.Items.Add("Product Name");
            date_txt.Text = DateTime.Today.ToString("yyyy/mm/dd");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conDataBase = new MySqlConnection(LoginForm.constring);
            MySqlDataReader myReader;
            String Query;
            switch(this.search_by.SelectedIndex)
            {
                case 0:
                    {
                        Query = "select * from departmentalstore.product_table where Product_ID = '" + this.value_to_search.Text + "'";
                        try
                        {
                            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                            conDataBase.Open();
                            myReader = cmdDataBase.ExecuteReader();
                            if (myReader.HasRows)
                            {
                                DataTable dt = new DataTable();
                                dt.Load(myReader);
                                stockGridView1.DataSource = dt;
                                Console.WriteLine("Searched");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            conDataBase.Close();
                        }
                        break;
                    }
                case 1:
                    {
                         Query = "select * from departmentalstore.product_table where Product_Name '" + this.value_to_search.Text + "'";
                         try
                         {
                             MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                             conDataBase.Open();
                             myReader = cmdDataBase.ExecuteReader();
                             if (myReader.HasRows)
                             {
                                 DataTable dt = new DataTable();
                                 dt.Load(myReader);
                                 stockGridView1.DataSource = dt;
                                 Console.WriteLine("Searched");
                             }
                         }
                         catch (Exception ex)
                         {
                             MessageBox.Show(ex.Message);
                             conDataBase.Close();
                         }
                         break;
                    }   
            }
        }

        private void stockGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.stockGridView1.Rows[e.RowIndex];
                product_code_txt.Text = row.Cells["Product_ID"].Value.ToString();
                product_name_txt.Text = row.Cells["Product_Name"].Value.ToString();
                unit_price_txt.Text = row.Cells["Price"].Value.ToString();
                //available_quantity_txt.Text = row.Cells["Quantity"].Value.ToString();

            }
        }

        private void salequantity_txt_TextChanged(object sender, EventArgs e)
        {
            double quantity;
            try
            {
                if (double.TryParse(salequantity_txt.Text, out quantity))
                {
                    double totalamount = Convert.ToDouble(unit_price_txt.Text) * quantity;
                    totalamount_txt.Text = totalamount.ToString();
                }

                else
                {
                    totalamount_txt.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void addtocart_button_Click(object sender, EventArgs e)
        {
            //string constring = "datasource=localhost;port=3306;username=ahnupsingh;password=Startwithme-55";
            MySqlConnection conDataBase = new MySqlConnection(LoginForm.constring);
            MySqlDataReader myReader;
            string Query1 = "insert into Departmentalstore.cart (Customer_Name, Product_ID, Quantity, Amount) values('" + this.customerName_txt.Text + "', '" + this.product_code_txt.Text + "','" + this.salequantity_txt.Text + "','" + this.totalamount_txt.Text + "');";
            try
            {
                MySqlCommand cmdDataBase = new MySqlCommand(Query1, conDataBase);
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {

                }
                Show.PerformClick();
                //MessageBox.Show("Added");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conDataBase.Close();
            } 
        }

        private void order_btn_Click(object sender, EventArgs e)
        {
            Forms.AddOrders add_order = new Forms.AddOrders();
            add_order.Show();
        }
        private void calculate_Click(object sender, EventArgs e)
        {
            //string constring = "datasource=localhost;port=3306;username=ahnupsingh;password=Startwithme-55";
            MySqlConnection conDataBase = new MySqlConnection(LoginForm.constring);
            MySqlDataReader myReader;
            string Query2 = "select sum(Amount) as sum from Departmentalstore.cart where Customer_Name = '"+ this.customerName_txt.Text+"' ";
            try
            {
                MySqlCommand cmdDataBase = new MySqlCommand(Query2, conDataBase);
                conDataBase.Open();
                using (myReader = cmdDataBase.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        this.GrandTotal_txt.Text = ("Rs: " + myReader["sum"].ToString());
                    }
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
                conDataBase.Close();
            } 
        }

        private void show_button_Click(object sender, EventArgs e)
        {
            MySqlConnection conDataBase = new MySqlConnection(LoginForm.constring);
            try
            {
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                String Query = "select Product_Name, Quantity, Price, Amount from departmentalstore.cart natural join departmentalstore.product_table where Customer_Name = '" + this.customerName_txt.Text + "'";
                //String Query = "select * from departmentalstore.cart where Customer_Name = '" + this.customerName_txt.Text + "'";
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                MySqlDataReader myReader;
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                if (myReader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(myReader);
                    customercartgridview.DataSource = dt;
                    Console.WriteLine("Searched");
                }
                calculate.PerformClick();
            }
                
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conDataBase.Close();
            }
        }

       /* private void stockGridView1_SizeChanged(object sender, EventArgs e)
        {
                DataGridViewCell cell = null;
                foreach(DataGridViewCell clickedcell in stockGridView1.SelectedCells)
                {
                    cell = clickedcell;
                    Console.WriteLine("cell clicked");
                    break;
                }
                if (cell != null)
                {
                    DataGridViewRow row = cell.OwningRow;
                    product_code_txt.Text = row.Cells["0"].Value.ToString();
                    product_name_txt.Text = row.Cells["1"].Value.ToString();
                    unit_price_txt.Text = row.Cells["2"].Value.ToString();
                    available_quantity_txt.Text = row.Cells["3"].Value.ToString();
                }
        }*/
    }
}
