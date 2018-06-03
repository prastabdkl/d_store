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

namespace dstore
{
    public partial class LoginForm : Form
    {
        public static string x;
        public static string constring;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ok__btn_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                MySqlCommand SelectCommand = new MySqlCommand("select * from Departmentalstore.logintable where Username = '" + this.username_txt.Text + "' and Password = '" + this.password_txt.Text + "' ;", myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    MessageBox.Show("Username and password is correct");
                    x = (string)myReader.GetValue(myReader.GetOrdinal("Designation"));

                    constring = "datasource=localhost;port=3306;username= "+ x + ";password=password";
                    myConn.Close();
                    Forms.SelectDepart selectDepart = new Forms.SelectDepart();
                    selectDepart.Show();
                    this.Close();

                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate Username and password....Access Denied");
                }
                else
                    MessageBox.Show("Username and password is not correct...Please try again");

                myConn.Close();

                /*MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter);
                myConn.Open();
                DataSet ds = new DataSet();
                MessageBox.Show("Connected");
                myConn.Close();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

       }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void username_label_Click(object sender, EventArgs e)
        {

        }

        }
    }
