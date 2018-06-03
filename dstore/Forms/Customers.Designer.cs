namespace dstore.Forms
{
    partial class Customers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchName = new System.Windows.Forms.TextBox();
            this.SearchCustomer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.addcustomerButton = new System.Windows.Forms.Button();
            this.Phone_txt = new System.Windows.Forms.TextBox();
            this.Address_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchAddress = new System.Windows.Forms.TextBox();
            this.SearchByCategory = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.instore_tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.instoreCustomerGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.onlineCustomerGridView = new System.Windows.Forms.DataGridView();
            this.SearchByName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.Customer_ID_txt = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.instore_tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instoreCustomerGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onlineCustomerGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Image = global::dstore.Properties.Resources.search;
            this.SearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchButton.Location = new System.Drawing.Point(420, 7);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 38);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchName
            // 
            this.SearchName.Location = new System.Drawing.Point(99, 22);
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(100, 20);
            this.SearchName.TabIndex = 2;
            // 
            // SearchCustomer
            // 
            this.SearchCustomer.Location = new System.Drawing.Point(139, 268);
            this.SearchCustomer.Name = "SearchCustomer";
            this.SearchCustomer.Size = new System.Drawing.Size(94, 55);
            this.SearchCustomer.TabIndex = 1;
            this.SearchCustomer.Text = "Search";
            this.SearchCustomer.UseVisualStyleBackColor = true;
            this.SearchCustomer.Click += new System.EventHandler(this.SearchCustomer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Type";
            // 
            // addcustomerButton
            // 
            this.addcustomerButton.Location = new System.Drawing.Point(15, 268);
            this.addcustomerButton.Name = "addcustomerButton";
            this.addcustomerButton.Size = new System.Drawing.Size(95, 55);
            this.addcustomerButton.TabIndex = 8;
            this.addcustomerButton.Text = "Add Customer";
            this.addcustomerButton.UseVisualStyleBackColor = true;
            this.addcustomerButton.Click += new System.EventHandler(this.addcustomerButton_Click);
            // 
            // Phone_txt
            // 
            this.Phone_txt.Location = new System.Drawing.Point(139, 167);
            this.Phone_txt.Name = "Phone_txt";
            this.Phone_txt.Size = new System.Drawing.Size(100, 20);
            this.Phone_txt.TabIndex = 7;
            // 
            // Address_txt
            // 
            this.Address_txt.Location = new System.Drawing.Point(139, 125);
            this.Address_txt.Name = "Address_txt";
            this.Address_txt.Size = new System.Drawing.Size(100, 20);
            this.Address_txt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Address";
            // 
            // SearchAddress
            // 
            this.SearchAddress.Location = new System.Drawing.Point(311, 22);
            this.SearchAddress.Name = "SearchAddress";
            this.SearchAddress.Size = new System.Drawing.Size(100, 20);
            this.SearchAddress.TabIndex = 4;
            // 
            // SearchByCategory
            // 
            this.SearchByCategory.AutoSize = true;
            this.SearchByCategory.Location = new System.Drawing.Point(205, 25);
            this.SearchByCategory.Name = "SearchByCategory";
            this.SearchByCategory.Size = new System.Drawing.Size(97, 13);
            this.SearchByCategory.TabIndex = 3;
            this.SearchByCategory.Text = "Search By Address";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.instore_tab);
            this.groupBox2.Controls.Add(this.SearchButton);
            this.groupBox2.Controls.Add(this.SearchAddress);
            this.groupBox2.Controls.Add(this.SearchByCategory);
            this.groupBox2.Controls.Add(this.SearchName);
            this.groupBox2.Controls.Add(this.SearchByName);
            this.groupBox2.Location = new System.Drawing.Point(294, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 347);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CUSTOMER SEARCH";
            // 
            // instore_tab
            // 
            this.instore_tab.Controls.Add(this.tabPage1);
            this.instore_tab.Controls.Add(this.tabPage2);
            this.instore_tab.Location = new System.Drawing.Point(9, 48);
            this.instore_tab.Name = "instore_tab";
            this.instore_tab.SelectedIndex = 0;
            this.instore_tab.Size = new System.Drawing.Size(489, 299);
            this.instore_tab.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.instoreCustomerGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(481, 273);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "IN-STORE";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // instoreCustomerGridView
            // 
            this.instoreCustomerGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.instoreCustomerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.instoreCustomerGridView.Location = new System.Drawing.Point(0, 0);
            this.instoreCustomerGridView.Name = "instoreCustomerGridView";
            this.instoreCustomerGridView.Size = new System.Drawing.Size(479, 273);
            this.instoreCustomerGridView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.onlineCustomerGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(481, 273);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ONLINE";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // onlineCustomerGridView
            // 
            this.onlineCustomerGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.onlineCustomerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.onlineCustomerGridView.Location = new System.Drawing.Point(1, 0);
            this.onlineCustomerGridView.Name = "onlineCustomerGridView";
            this.onlineCustomerGridView.Size = new System.Drawing.Size(479, 273);
            this.onlineCustomerGridView.TabIndex = 1;
            // 
            // SearchByName
            // 
            this.SearchByName.AutoSize = true;
            this.SearchByName.Location = new System.Drawing.Point(6, 25);
            this.SearchByName.Name = "SearchByName";
            this.SearchByName.Size = new System.Drawing.Size(87, 13);
            this.SearchByName.TabIndex = 1;
            this.SearchByName.Text = "Search By Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone No";
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(139, 83);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(100, 20);
            this.name_txt.TabIndex = 3;
            // 
            // Customer_ID_txt
            // 
            this.Customer_ID_txt.Location = new System.Drawing.Point(139, 40);
            this.Customer_ID_txt.Name = "Customer_ID_txt";
            this.Customer_ID_txt.Size = new System.Drawing.Size(100, 20);
            this.Customer_ID_txt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.SearchCustomer);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.addcustomerButton);
            this.groupBox1.Controls.Add(this.Phone_txt);
            this.groupBox1.Controls.Add(this.Address_txt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.name_txt);
            this.groupBox1.Controls.Add(this.Customer_ID_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 347);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CUSTOMER INFO";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Online",
            "InStore"});
            this.comboBox1.Location = new System.Drawing.Point(139, 207);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 360);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Customers";
            this.Text = "Customers";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.instore_tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.instoreCustomerGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.onlineCustomerGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchName;
        private System.Windows.Forms.Button SearchCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addcustomerButton;
        private System.Windows.Forms.TextBox Phone_txt;
        private System.Windows.Forms.TextBox Address_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SearchAddress;
        private System.Windows.Forms.Label SearchByCategory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label SearchByName;
        private System.Windows.Forms.DataGridView instoreCustomerGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.MaskedTextBox Customer_ID_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl instore_tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView onlineCustomerGridView;

    }
}