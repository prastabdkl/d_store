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
    public partial class AddUserForm : Form
    {
        MySqlConnection conDataBase = new MySqlConnection(LoginForm.constring);
        MySqlDataReader myReader;
        public AddUserForm()
        {
            InitializeComponent();
            comboBox1.Items.Add("Manager");
            comboBox1.Items.Add("Auto Staff");
            comboBox1.Items.Add("Sales Person");
            comboBox1.Items.Add("Accountant");
            comboBox1.Items.Add("Other");

            try
            {
                string Query = "select username from departmentalstore.logintable where username != '" + null + "'";
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                conDataBase.Open();
                /*myReader = cmdDataBase.ExecuteReader();
                if (myReader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(myReader);
                    dataGridView1.DataSource = dt;
                }*/
            }
            finally
            {
                conDataBase.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (password_txt.Text != re_password_txt.Text)
            {
                MessageBox.Show("Passwords Does not match");
            }
            else
            {
                string Query = "insert into Departmentalstore.logintable (Username, Password, Designation, ID) values('" + this.username_txt.Text + "', '" + this.password_txt.Text + "' , '" + this.comboBox1.Text + "', '" + this.id_text.Text + "' );";
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
                    conDataBase.Close();
                }
            }
 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            password_txt.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
