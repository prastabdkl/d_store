namespace dstore.Forms
{
    partial class Sales
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
            this.order_btn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.calculate = new System.Windows.Forms.Button();
            this.GrandTotal_txt = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addtocart_button = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.totalamount_txt = new System.Windows.Forms.TextBox();
            this.available_quantity_txt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.product_name_txt = new System.Windows.Forms.TextBox();
            this.salequantity_txt = new System.Windows.Forms.TextBox();
            this.unit_price_txt = new System.Windows.Forms.TextBox();
            this.product_code_txt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.customerName_txt = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.date_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.value_to_search = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.search_by = new System.Windows.Forms.ComboBox();
            this.stockGridView1 = new System.Windows.Forms.DataGridView();
            this.customercartgridview = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Show = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customercartgridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.order_btn);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 488);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // order_btn
            // 
            this.order_btn.Location = new System.Drawing.Point(366, 127);
            this.order_btn.Name = "order_btn";
            this.order_btn.Size = new System.Drawing.Size(105, 44);
            this.order_btn.TabIndex = 12;
            this.order_btn.Text = "ORDERS";
            this.order_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.order_btn.UseVisualStyleBackColor = true;
            this.order_btn.Click += new System.EventHandler(this.order_btn_Click);
            // 
            // button5
            // 
            this.button5.Image = global::dstore.Properties.Resources.save_as1;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(366, 77);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 44);
            this.button5.TabIndex = 11;
            this.button5.Text = "SAVE";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = global::dstore.Properties.Resources.add_list;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(366, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 46);
            this.button4.TabIndex = 10;
            this.button4.Text = "NEW";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Controls.Add(this.calculate);
            this.groupBox4.Controls.Add(this.GrandTotal_txt);
            this.groupBox4.Controls.Add(this.textBox18);
            this.groupBox4.Controls.Add(this.textBox10);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(3, 322);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(471, 166);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "GRAND TOTAL";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(3, 129);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(172, 31);
            this.calculate.TabIndex = 25;
            this.calculate.Text = "CALCULATE";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // GrandTotal_txt
            // 
            this.GrandTotal_txt.Font = new System.Drawing.Font("Niagara Solid", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrandTotal_txt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.GrandTotal_txt.Location = new System.Drawing.Point(3, 16);
            this.GrandTotal_txt.Multiline = true;
            this.GrandTotal_txt.Name = "GrandTotal_txt";
            this.GrandTotal_txt.Size = new System.Drawing.Size(172, 107);
            this.GrandTotal_txt.TabIndex = 24;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(351, 69);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(117, 20);
            this.textBox18.TabIndex = 23;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(351, 20);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(117, 20);
            this.textBox10.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(220, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Payment Due";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(220, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Total Payment";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox3.Controls.Add(this.addtocart_button);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.totalamount_txt);
            this.groupBox3.Controls.Add(this.available_quantity_txt);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.product_name_txt);
            this.groupBox3.Controls.Add(this.salequantity_txt);
            this.groupBox3.Controls.Add(this.unit_price_txt);
            this.groupBox3.Controls.Add(this.product_code_txt);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(6, 182);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(348, 141);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ITEM DETAIL";
            // 
            // addtocart_button
            // 
            this.addtocart_button.Location = new System.Drawing.Point(9, 104);
            this.addtocart_button.Name = "addtocart_button";
            this.addtocart_button.Size = new System.Drawing.Size(336, 23);
            this.addtocart_button.TabIndex = 15;
            this.addtocart_button.Text = "Add to Cart";
            this.addtocart_button.UseVisualStyleBackColor = true;
            this.addtocart_button.Click += new System.EventHandler(this.addtocart_button_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(178, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Total Amount";
            // 
            // totalamount_txt
            // 
            this.totalamount_txt.Enabled = false;
            this.totalamount_txt.Location = new System.Drawing.Point(276, 73);
            this.totalamount_txt.Name = "totalamount_txt";
            this.totalamount_txt.Size = new System.Drawing.Size(66, 20);
            this.totalamount_txt.TabIndex = 18;
            // 
            // available_quantity_txt
            // 
            this.available_quantity_txt.Enabled = false;
            this.available_quantity_txt.Location = new System.Drawing.Point(276, 49);
            this.available_quantity_txt.Name = "available_quantity_txt";
            this.available_quantity_txt.Size = new System.Drawing.Size(66, 20);
            this.available_quantity_txt.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(178, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Available Quantity";
            // 
            // product_name_txt
            // 
            this.product_name_txt.Enabled = false;
            this.product_name_txt.Location = new System.Drawing.Point(181, 23);
            this.product_name_txt.Name = "product_name_txt";
            this.product_name_txt.Size = new System.Drawing.Size(161, 20);
            this.product_name_txt.TabIndex = 14;
            // 
            // salequantity_txt
            // 
            this.salequantity_txt.Location = new System.Drawing.Point(85, 49);
            this.salequantity_txt.Name = "salequantity_txt";
            this.salequantity_txt.Size = new System.Drawing.Size(83, 20);
            this.salequantity_txt.TabIndex = 13;
            this.salequantity_txt.TextChanged += new System.EventHandler(this.salequantity_txt_TextChanged);
            // 
            // unit_price_txt
            // 
            this.unit_price_txt.Enabled = false;
            this.unit_price_txt.Location = new System.Drawing.Point(85, 73);
            this.unit_price_txt.Name = "unit_price_txt";
            this.unit_price_txt.Size = new System.Drawing.Size(83, 20);
            this.unit_price_txt.TabIndex = 12;
            // 
            // product_code_txt
            // 
            this.product_code_txt.Enabled = false;
            this.product_code_txt.Location = new System.Drawing.Point(85, 23);
            this.product_code_txt.Name = "product_code_txt";
            this.product_code_txt.Size = new System.Drawing.Size(83, 20);
            this.product_code_txt.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Sale Quantity";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Unit Price";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Item Name";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.customerName_txt);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.textBox5);
            this.groupBox5.Controls.Add(this.textBox7);
            this.groupBox5.Controls.Add(this.date_txt);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(6, 25);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(348, 148);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "BILLING";
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(354, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(117, 298);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            // 
            // customerName_txt
            // 
            this.customerName_txt.Location = new System.Drawing.Point(97, 65);
            this.customerName_txt.Name = "customerName_txt";
            this.customerName_txt.Size = new System.Drawing.Size(163, 20);
            this.customerName_txt.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(266, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 20);
            this.button3.TabIndex = 9;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(97, 93);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(163, 20);
            this.textBox5.TabIndex = 8;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(97, 39);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(163, 20);
            this.textBox7.TabIndex = 6;
            // 
            // date_txt
            // 
            this.date_txt.Enabled = false;
            this.date_txt.Location = new System.Drawing.Point(97, 13);
            this.date_txt.Name = "date_txt";
            this.date_txt.Size = new System.Drawing.Size(163, 20);
            this.date_txt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Invoice ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Customer Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Phone No:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Date";
            // 
            // value_to_search
            // 
            this.value_to_search.Location = new System.Drawing.Point(514, 41);
            this.value_to_search.Name = "value_to_search";
            this.value_to_search.Size = new System.Drawing.Size(163, 20);
            this.value_to_search.TabIndex = 12;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(683, 45);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "Search By:";
            // 
            // search_by
            // 
            this.search_by.FormattingEnabled = true;
            this.search_by.Location = new System.Drawing.Point(748, 41);
            this.search_by.Name = "search_by";
            this.search_by.Size = new System.Drawing.Size(121, 21);
            this.search_by.TabIndex = 13;
            this.search_by.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // stockGridView1
            // 
            this.stockGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stockGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockGridView1.Location = new System.Drawing.Point(486, 68);
            this.stockGridView1.Name = "stockGridView1";
            this.stockGridView1.Size = new System.Drawing.Size(449, 241);
            this.stockGridView1.TabIndex = 14;
            this.stockGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockGridView1_CellContentClick);
            // 
            // customercartgridview
            // 
            this.customercartgridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customercartgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customercartgridview.Location = new System.Drawing.Point(486, 338);
            this.customercartgridview.Name = "customercartgridview";
            this.customercartgridview.Size = new System.Drawing.Size(448, 150);
            this.customercartgridview.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(486, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Stocks";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::dstore.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(487, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(483, 315);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(451, 20);
            this.Show.TabIndex = 27;
            this.Show.Text = "Customer Cart";
            this.Show.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.show_button_Click);
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 485);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customercartgridview);
            this.Controls.Add(this.stockGridView1);
            this.Controls.Add(this.search_by);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.value_to_search);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Sales";
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customercartgridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox salequantity_txt;
        private System.Windows.Forms.TextBox unit_price_txt;
        private System.Windows.Forms.TextBox product_code_txt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox product_name_txt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox totalamount_txt;
        private System.Windows.Forms.TextBox available_quantity_txt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox value_to_search;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox search_by;
        private System.Windows.Forms.DataGridView stockGridView1;
        private System.Windows.Forms.Button addtocart_button;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox customerName_txt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox date_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView customercartgridview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button order_btn;
        private System.Windows.Forms.TextBox GrandTotal_txt;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button Show;
    }
}