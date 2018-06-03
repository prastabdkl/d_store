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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            this.Height = 450;
            this.Width = 575;

            MySqlConnection conDataBase = new MySqlConnection(LoginForm.constring);
            MySqlDataReader myReader;
            MessageBox.Show(LoginForm.x);
            try
            {
                string Query = "select Order_Date, Customer_Name, Product_Name, Quantity, Location from departmentalstore.order order by Order_Date LIMIT 5";
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                if (myReader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(myReader);
                    orderGridView1.DataSource = dt;
                    Console.WriteLine("Searched");
                    conDataBase.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }

        }

        private void ProductTool_Click(object sender, EventArgs e)
        {
            Forms.Product productview = new Forms.Product();
            productview.Show();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.AddUserForm add = new Forms.AddUserForm();
            add.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            /*Forms.Stock stock = new Forms.Stock();
            stock.Show();*/
            Forms.Product productview = new Forms.Product();
            productview.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Forms.Sales sales = new Forms.Sales();
            sales.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Forms.Customers customer_form = new Forms.Customers();
            customer_form.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Product productview = new Forms.Product();
            productview.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Forms.ConfigProduct config = new Forms.ConfigProduct();
            config.Show();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            Forms.Manufacturer man = new Forms.Manufacturer();
            man.Show();
        }

        private void toolStripLabel9_Click(object sender, EventArgs e)
        {
            Forms.autoStaffForm ord = new Forms.autoStaffForm();
            ord.Show();
        }

        private void toolStripLabel6_Click(object sender, EventArgs e)
        {
            Forms.Customers customer_form = new Forms.Customers();
            customer_form.Show();
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.ConfigProduct config = new ConfigProduct();
            config.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Forms.Assets asset = new Forms.Assets();
            asset.Show();
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            Forms.Branches branch = new Forms.Branches();
            branch.Show();
        }

        private void toolStripLabel8_Click(object sender, EventArgs e)
        {
            Forms.AccountForm salesdata= new Forms.AccountForm();
            salesdata.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            ActiveForm.Close();
            log.Show();
            
        }
    }
}
