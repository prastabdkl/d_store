namespace dstore.Forms
{
    partial class ConfigProduct
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
            this.SearchName = new System.Windows.Forms.TextBox();
            this.productGridView1 = new System.Windows.Forms.DataGridView();
            this.UpdateProduct = new System.Windows.Forms.Button();
            this.Price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.Manufacturer = new System.Windows.Forms.TextBox();
            this.Category = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchCategory = new System.Windows.Forms.TextBox();
            this.SearchByCategory = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SearchByName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Product_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Product_ID = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchName
            // 
            this.SearchName.Location = new System.Drawing.Point(99, 22);
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(100, 20);
            this.SearchName.TabIndex = 2;
            // 
            // productGridView1
            // 
            this.productGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.productGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView1.Location = new System.Drawing.Point(9, 51);
            this.productGridView1.Name = "productGridView1";
            this.productGridView1.Size = new System.Drawing.Size(495, 296);
            this.productGridView1.TabIndex = 0;
            this.productGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productGridView1_CellContentClick);
            // 
            // UpdateProduct
            // 
            this.UpdateProduct.Location = new System.Drawing.Point(139, 257);
            this.UpdateProduct.Name = "UpdateProduct";
            this.UpdateProduct.Size = new System.Drawing.Size(94, 55);
            this.UpdateProduct.TabIndex = 1;
            this.UpdateProduct.Text = "UPDATE";
            this.UpdateProduct.UseVisualStyleBackColor = true;
            this.UpdateProduct.Click += new System.EventHandler(this.UpdateProduct_Click);
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(139, 212);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(100, 20);
            this.Price.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(10, 257);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(95, 55);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Manufacturer
            // 
            this.Manufacturer.Location = new System.Drawing.Point(139, 167);
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.Size = new System.Drawing.Size(100, 20);
            this.Manufacturer.TabIndex = 7;
            // 
            // Category
            // 
            this.Category.Location = new System.Drawing.Point(139, 125);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(100, 20);
            this.Category.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Category";
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
            // SearchCategory
            // 
            this.SearchCategory.Location = new System.Drawing.Point(311, 22);
            this.SearchCategory.Name = "SearchCategory";
            this.SearchCategory.Size = new System.Drawing.Size(100, 20);
            this.SearchCategory.TabIndex = 4;
            // 
            // SearchByCategory
            // 
            this.SearchByCategory.AutoSize = true;
            this.SearchByCategory.Location = new System.Drawing.Point(205, 25);
            this.SearchByCategory.Name = "SearchByCategory";
            this.SearchByCategory.Size = new System.Drawing.Size(101, 13);
            this.SearchByCategory.TabIndex = 3;
            this.SearchByCategory.Text = "Search By Category";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SearchButton);
            this.groupBox2.Controls.Add(this.SearchCategory);
            this.groupBox2.Controls.Add(this.SearchByCategory);
            this.groupBox2.Controls.Add(this.SearchName);
            this.groupBox2.Controls.Add(this.SearchByName);
            this.groupBox2.Controls.Add(this.productGridView1);
            this.groupBox2.Location = new System.Drawing.Point(273, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 347);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PRODUCT SEARCH";
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
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Manufacturer";
            // 
            // Product_Name
            // 
            this.Product_Name.Location = new System.Drawing.Point(139, 83);
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.Size = new System.Drawing.Size(100, 20);
            this.Product_Name.TabIndex = 3;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.UpdateProduct);
            this.groupBox1.Controls.Add(this.Price);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.Manufacturer);
            this.groupBox1.Controls.Add(this.Category);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Product_Name);
            this.groupBox1.Controls.Add(this.Product_ID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 347);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONFIGURE PRODUCT";
            // 
            // Product_ID
            // 
            this.Product_ID.Enabled = false;
            this.Product_ID.Location = new System.Drawing.Point(139, 40);
            this.Product_ID.Name = "Product_ID";
            this.Product_ID.Size = new System.Drawing.Size(100, 20);
            this.Product_ID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID";
            // 
            // ConfigProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 361);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConfigProduct";
            this.Text = "Product Configuration";
            ((System.ComponentModel.ISupportInitialize)(this.productGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox SearchName;
        private System.Windows.Forms.DataGridView productGridView1;
        private System.Windows.Forms.Button UpdateProduct;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox Manufacturer;
        private System.Windows.Forms.TextBox Category;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchCategory;
        private System.Windows.Forms.Label SearchByCategory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label SearchByName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Product_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox Product_ID;
        private System.Windows.Forms.Label label1;
    }
}