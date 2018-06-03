namespace dstore.Forms
{
    partial class Manufacturer
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
            this.ManufacturerGroup = new System.Windows.Forms.GroupBox();
            this.export_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ManufacturerGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 282);
            this.dataGridView1.TabIndex = 0;
            // 
            // ManufacturerGroup
            // 
            this.ManufacturerGroup.Controls.Add(this.export_button);
            this.ManufacturerGroup.Controls.Add(this.dataGridView1);
            this.ManufacturerGroup.Location = new System.Drawing.Point(12, 12);
            this.ManufacturerGroup.Name = "ManufacturerGroup";
            this.ManufacturerGroup.Size = new System.Drawing.Size(586, 307);
            this.ManufacturerGroup.TabIndex = 1;
            this.ManufacturerGroup.TabStop = false;
            this.ManufacturerGroup.Text = "MANUFACTURERS";
            // 
            // export_button
            // 
            this.export_button.Location = new System.Drawing.Point(454, 253);
            this.export_button.Name = "export_button";
            this.export_button.Size = new System.Drawing.Size(124, 48);
            this.export_button.TabIndex = 1;
            this.export_button.Text = "EXPORT TO EXCEL";
            this.export_button.UseVisualStyleBackColor = true;
            this.export_button.Click += new System.EventHandler(this.export_button_Click);
            // 
            // Manufacturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 331);
            this.Controls.Add(this.ManufacturerGroup);
            this.Name = "Manufacturer";
            this.Text = "Manufacturers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ManufacturerGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox ManufacturerGroup;
        private System.Windows.Forms.Button export_button;
    }
}