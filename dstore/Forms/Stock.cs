using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dstore.Forms
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {/*
            string Query = "insert into Departmentalstore.stock (Product_ID, Product_Name, Unit_Price, Quantity) values('" + this.username_txt.Text + "', '" + this.password_txt.Text + "' , '" + this.comboBox1.Text + "', '" + this.id_text.Text + "' );";
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
                conDataBase.Close();
            }*/
        }
    }
}
