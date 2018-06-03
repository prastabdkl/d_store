namespace dstore
{
    partial class LoginForm
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
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.ok__btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(165, 48);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(64, 13);
            this.username_label.TabIndex = 0;
            this.username_label.Text = "Username : ";
            this.username_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(167, 88);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(62, 13);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "Password : ";
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(235, 45);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(275, 20);
            this.username_txt.TabIndex = 2;
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(235, 88);
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '*';
            this.password_txt.Size = new System.Drawing.Size(275, 20);
            this.password_txt.TabIndex = 3;
            // 
            // ok__btn
            // 
            this.ok__btn.Location = new System.Drawing.Point(218, 148);
            this.ok__btn.Name = "ok__btn";
            this.ok__btn.Size = new System.Drawing.Size(75, 23);
            this.ok__btn.TabIndex = 4;
            this.ok__btn.Text = "OK";
            this.ok__btn.UseVisualStyleBackColor = true;
            this.ok__btn.Click += new System.EventHandler(this.ok__btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_btn.Location = new System.Drawing.Point(375, 148);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 4;
            this.cancel_btn.Text = "CANCEL";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::dstore.Properties.Resources.man_pushing_a_shopping_cart_icon_70283;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.ok__btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.cancel_btn;
            this.ClientSize = new System.Drawing.Size(522, 214);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.ok__btn);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Member Login Page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Button ok__btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

