namespace IM
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.login_username = new System.Windows.Forms.TextBox();
            this.login_password = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.login_showPass = new System.Windows.Forms.CheckBox();
            this.login_level = new System.Windows.Forms.ComboBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.login_close = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // login_username
            // 
            this.login_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_username.Location = new System.Drawing.Point(116, 138);
            this.login_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(200, 28);
            this.login_username.TabIndex = 1;
            // 
            // login_password
            // 
            this.login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_password.Location = new System.Drawing.Point(117, 190);
            this.login_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_password.Name = "login_password";
            this.login_password.PasswordChar = '*';
            this.login_password.Size = new System.Drawing.Size(200, 28);
            this.login_password.TabIndex = 2;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.login_btn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Location = new System.Drawing.Point(178, 241);
            this.login_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(77, 28);
            this.login_btn.TabIndex = 7;
            this.login_btn.Text = "LOGIN";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // login_showPass
            // 
            this.login_showPass.AutoSize = true;
            this.login_showPass.Location = new System.Drawing.Point(349, 296);
            this.login_showPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_showPass.Name = "login_showPass";
            this.login_showPass.Size = new System.Drawing.Size(65, 20);
            this.login_showPass.TabIndex = 10;
            this.login_showPass.Text = "Show ";
            this.login_showPass.UseVisualStyleBackColor = true;
            this.login_showPass.CheckedChanged += new System.EventHandler(this.signup_showPass_CheckedChanged);
            // 
            // login_level
            // 
            this.login_level.FormattingEnabled = true;
            this.login_level.Items.AddRange(new object[] {
            "ADMIN",
            "USER"});
            this.login_level.Location = new System.Drawing.Point(23, 293);
            this.login_level.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_level.Name = "login_level";
            this.login_level.Size = new System.Drawing.Size(82, 24);
            this.login_level.TabIndex = 12;
            this.login_level.Text = "LEVEL";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(-6, -1);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(446, 326);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 19;
            this.pictureBox9.TabStop = false;
            // 
            // login_close
            // 
            this.login_close.AutoSize = true;
            this.login_close.Location = new System.Drawing.Point(421, -3);
            this.login_close.Name = "login_close";
            this.login_close.Size = new System.Drawing.Size(13, 16);
            this.login_close.TabIndex = 11;
            this.login_close.Text = "x";
            this.login_close.Click += new System.EventHandler(this.login_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 325);
            this.Controls.Add(this.login_level);
            this.Controls.Add(this.login_close);
            this.Controls.Add(this.login_showPass);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.login_password);
            this.Controls.Add(this.login_username);
            this.Controls.Add(this.pictureBox9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.CheckBox login_showPass;
        private System.Windows.Forms.ComboBox login_level;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label login_close;
    }
}

