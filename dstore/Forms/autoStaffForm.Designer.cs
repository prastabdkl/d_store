namespace dstore.Forms
{
    partial class autoStaffForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewOrders_btn = new System.Windows.Forms.Button();
            this.viewDelivery_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(578, 219);
            this.dataGridView1.TabIndex = 0;
            // 
            // viewOrders_btn
            // 
            this.viewOrders_btn.Location = new System.Drawing.Point(592, 150);
            this.viewOrders_btn.Name = "viewOrders_btn";
            this.viewOrders_btn.Size = new System.Drawing.Size(132, 45);
            this.viewOrders_btn.TabIndex = 1;
            this.viewOrders_btn.Text = "View Orders";
            this.viewOrders_btn.UseVisualStyleBackColor = true;
            this.viewOrders_btn.Click += new System.EventHandler(this.viewOrders_btn_Click);
            // 
            // viewDelivery_btn
            // 
            this.viewDelivery_btn.Location = new System.Drawing.Point(592, 201);
            this.viewDelivery_btn.Name = "viewDelivery_btn";
            this.viewDelivery_btn.Size = new System.Drawing.Size(132, 45);
            this.viewDelivery_btn.TabIndex = 2;
            this.viewDelivery_btn.Text = "View Delivery";
            this.viewDelivery_btn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.viewDelivery_btn);
            this.groupBox1.Controls.Add(this.viewOrders_btn);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 258);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ORDERS AND DELIVERY";
            // 
            // autoStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 261);
            this.Controls.Add(this.groupBox1);
            this.Name = "autoStaffForm";
            this.Text = "ABC Departmental Store";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button viewOrders_btn;
        private System.Windows.Forms.Button viewDelivery_btn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}