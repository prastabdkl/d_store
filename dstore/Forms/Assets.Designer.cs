namespace dstore.Forms
{
    partial class Assets
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
            this.export_button = new System.Windows.Forms.Button();
            this.ManufacturerGroup = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ManufacturerGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // ManufacturerGroup
            // 
            this.ManufacturerGroup.Controls.Add(this.export_button);
            this.ManufacturerGroup.Controls.Add(this.dataGridView1);
            this.ManufacturerGroup.Location = new System.Drawing.Point(12, 12);
            this.ManufacturerGroup.Name = "ManufacturerGroup";
            this.ManufacturerGroup.Size = new System.Drawing.Size(586, 307);
            this.ManufacturerGroup.TabIndex = 2;
            this.ManufacturerGroup.TabStop = false;
            this.ManufacturerGroup.Text = "ASSETS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 282);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Assets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 331);
            this.Controls.Add(this.ManufacturerGroup);
            this.Name = "Assets";
            this.Text = "Assets";
            this.ManufacturerGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button export_button;
        private System.Windows.Forms.GroupBox ManufacturerGroup;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}