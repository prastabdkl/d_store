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
    public partial class autoStaffForm : Form
    {
        public autoStaffForm()
        {
            InitializeComponent();
        }

        private void viewOrders_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection conDataBase = new MySqlConnection(LoginForm.constring);
            MySqlDataReader myReader;
            try
            {
                string Query = "select Order_Date, Customer_Name, Product_Name, Quantity, Location, Delivery_Date from departmentalstore.order order by Order_Date";
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                if (myReader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(myReader);
                    dataGridView1.DataSource = dt;
                    Console.WriteLine("Searched");
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conDataBase.Close();
            }
        }
    }
}
