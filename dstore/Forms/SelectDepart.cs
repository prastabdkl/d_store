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
    public partial class SelectDepart : Form
    {
        public SelectDepart()
        {
            InitializeComponent();
        }

        private void manager_button_Click(object sender, EventArgs e)
        {
                try
                {
                    Forms.MainPage mainpage = new Forms.MainPage();
                    this.Hide();
                    mainpage.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               // MessageBox.Show("Form Access Denied");
        }

        private void sales_button_Click(object sender, EventArgs e)
        {
            if (LoginForm.x == "SalesPerson" || LoginForm.x == "Manager")
            {
                Forms.Sales salesForm = new Forms.Sales();
                this.Hide();
                salesForm.Show();
            }
            else
                MessageBox.Show("Form Access Denied");
        }

        private void auto_button_Click(object sender, EventArgs e)
        {
            if (LoginForm.x == "AutoStaff" || LoginForm.x == "Manager")
            {
                Forms.autoStaffForm autoForm = new Forms.autoStaffForm();
                this.Hide();
                autoForm.Show();
            }
            else
                MessageBox.Show("Form Access Denied");
        }

        private void accounting_button_Click(object sender, EventArgs e)
        {
            if (LoginForm.x == "Accountant" || LoginForm.x == "Manager")
            {
                Forms.AccountForm accounting = new Forms.AccountForm();
                accounting.Show();
            }
            else
                MessageBox.Show("Form Access Denied");
        }
    }
}
