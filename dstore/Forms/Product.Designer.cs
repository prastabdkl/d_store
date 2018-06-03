namespace dstore.Forms
{
    partial class Product
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchProduct = new System.Windows.Forms.Button();
            this.Price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addProductButton = new System.Windows.Forms.Button();
            this.Manufacturer = new System.Windows.Forms.TextBox();
            this.Category = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Product_name = new System.Windows.Forms.TextBox();
            this.Product_ID = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchCategory = new System.Windows.Forms.TextBox();
            this.SearchByCategory = new System.Windows.Forms.Label();
            this.SearchName = new System.Windows.Forms.TextBox();
            this.SearchByName = new System.Windows.Forms.Label();
            this.productGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.SearchProduct);
            this.groupBox1.Controls.Add(this.Price);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.addProductButton);
            this.groupBox1.Controls.Add(this.Manufacturer);
            this.groupBox1.Controls.Add(this.Category);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Product_name);
            this.groupBox1.Controls.Add(this.Product_ID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 347);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRODUCT INFO";
            // 
            // SearchProduct
            // 
            this.SearchProduct.Location = new System.Drawing.Point(139, 268);
            this.SearchProduct.Name = "SearchProduct";
            this.SearchProduct.Size = new System.Drawing.Size(94, 55);
            this.SearchProduct.TabIndex = 1;
            this.SearchProduct.Text = "Search";
            this.SearchProduct.UseVisualStyleBackColor = true;
            this.SearchProduct.Click += new System.EventHandler(this.SearchProduct_Click);
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
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(15, 268);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(95, 55);
            this.addProductButton.TabIndex = 8;
            this.addProductButton.Text = "Add Product";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Manufacturer";
            // 
            // Product_name
            // 
            this.Product_name.Location = new System.Drawing.Point(139, 83);
            this.Product_name.Name = "Product_name";
            this.Product_name.Size = new System.Drawing.Size(100, 20);
            this.Product_name.TabIndex = 3;
            // 
            // Product_ID
            // 
            this.Product_ID.Location = new System.Drawing.Point(139, 40);
            this.Product_ID.Name = "Product_ID";
            this.Product_ID.Size = new System.Drawing.Size(100, 20);
            this.Product_ID.TabIndex = 2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SearchButton);
            this.groupBox2.Controls.Add(this.SearchCategory);
            this.groupBox2.Controls.Add(this.SearchByCategory);
            this.groupBox2.Controls.Add(this.SearchName);
            this.groupBox2.Controls.Add(this.SearchByName);
            this.groupBox2.Controls.Add(this.productGridView1);
            this.groupBox2.Location = new System.Drawing.Point(289, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 347);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PRODUCT SEARCH";
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
            this.SearchButton.Click += new System.EventHandler(this.searchButton_Click);
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
            // SearchName
            // 
            this.SearchName.Location = new System.Drawing.Point(99, 22);
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(100, 20);
            this.SearchName.TabIndex = 2;
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
            // productGridView1
            // 
            this.productGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.productGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView1.Location = new System.Drawing.Point(0, 50);
            this.productGridView1.Name = "productGridView1";
            this.productGridView1.Size = new System.Drawing.Size(495, 297);
            this.productGridView1.TabIndex = 0;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 352);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Product";
            this.Text = "Product";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Manufacturer;
        private System.Windows.Forms.TextBox Category;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Product_name;
        private System.Windows.Forms.MaskedTextBox Product_ID;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SearchProduct;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView productGridView1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchCategory;
        private System.Windows.Forms.Label SearchByCategory;
        private System.Windows.Forms.TextBox SearchName;
        private System.Windows.Forms.Label SearchByName;
    }
}