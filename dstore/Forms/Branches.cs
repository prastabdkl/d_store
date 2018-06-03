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
    public partial class Branches : Form
    {
        public Branches()
        {
            InitializeComponent();
            string constring = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlDataReader myReader;
            try
            {
                string Query = "select * from departmentalstore.department";
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                if (myReader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(myReader);
                    this.dataGridView1.DataSource = dt;
                    Console.WriteLine("Searched");
                    conDataBase.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            log.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            log.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            log.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            log.Show();
        }
    }
}
