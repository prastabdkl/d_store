namespace dstore.Forms
{
    partial class SelectDepart
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
            this.sales_button = new System.Windows.Forms.Button();
            this.auto_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.manager_button = new System.Windows.Forms.Button();
            this.accounting_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sales_button
            // 
            this.sales_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sales_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sales_button.Location = new System.Drawing.Point(29, 81);
            this.sales_button.Name = "sales_button";
            this.sales_button.Size = new System.Drawing.Size(238, 45);
            this.sales_button.TabIndex = 1;
            this.sales_button.Text = "Sales Department";
            this.sales_button.UseVisualStyleBackColor = false;
            this.sales_button.Click += new System.EventHandler(this.sales_button_Click);
            // 
            // auto_button
            // 
            this.auto_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.auto_button.Location = new System.Drawing.Point(29, 181);
            this.auto_button.Name = "auto_button";
            this.auto_button.Size = new System.Drawing.Size(238, 45);
            this.auto_button.TabIndex = 3;
            this.auto_button.Text = "Auto Department";
            this.auto_button.UseVisualStyleBackColor = false;
            this.auto_button.Click += new System.EventHandler(this.auto_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Controls.Add(this.sales_button);
            this.groupBox1.Controls.Add(this.manager_button);
            this.groupBox1.Controls.Add(this.auto_button);
            this.groupBox1.Controls.Add(this.accounting_button);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 258);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DEPARTMENTS";
            // 
            // manager_button
            // 
            this.manager_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.manager_button.Image = global::dstore.Properties.Resources.newspaper;
            this.manager_button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.manager_button.Location = new System.Drawing.Point(29, 30);
            this.manager_button.Name = "manager_button";
            this.manager_button.Size = new System.Drawing.Size(238, 45);
            this.manager_button.TabIndex = 0;
            this.manager_button.Text = "Managing Department";
            this.manager_button.UseVisualStyleBackColor = false;
            this.manager_button.Click += new System.EventHandler(this.manager_button_Click);
            // 
            // accounting_button
            // 
            this.accounting_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.accounting_button.Image = global::dstore.Properties.Resources.coins;
            this.accounting_button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.accounting_button.Location = new System.Drawing.Point(29, 132);
            this.accounting_button.Name = "accounting_button";
            this.accounting_button.Size = new System.Drawing.Size(238, 45);
            this.accounting_button.TabIndex = 2;
            this.accounting_button.Text = "Accounting Department";
            this.accounting_button.UseVisualStyleBackColor = false;
            this.accounting_button.Click += new System.EventHandler(this.accounting_button_Click);
            // 
            // SelectDepart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 261);
            this.Controls.Add(this.groupBox1);
            this.Name = "SelectDepart";
            this.Text = "Select Your Department";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manager_button;
        private System.Windows.Forms.Button sales_button;
        private System.Windows.Forms.Button accounting_button;
        private System.Windows.Forms.Button auto_button;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}