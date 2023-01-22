namespace EmployeeManagement
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
            this.LBL_title = new System.Windows.Forms.Label();
            this.TXTB_email = new System.Windows.Forms.TextBox();
            this.LBL_email = new System.Windows.Forms.Label();
            this.LBL_password = new System.Windows.Forms.Label();
            this.TXTB_password = new System.Windows.Forms.TextBox();
            this.BTN_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_title
            // 
            this.LBL_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_title.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_title.Location = new System.Drawing.Point(12, 9);
            this.LBL_title.Name = "LBL_title";
            this.LBL_title.Size = new System.Drawing.Size(310, 71);
            this.LBL_title.TabIndex = 0;
            this.LBL_title.Text = "Employee Mangement";
            this.LBL_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXTB_email
            // 
            this.TXTB_email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTB_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTB_email.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTB_email.Location = new System.Drawing.Point(12, 115);
            this.TXTB_email.Name = "TXTB_email";
            this.TXTB_email.Size = new System.Drawing.Size(310, 27);
            this.TXTB_email.TabIndex = 1;
            this.TXTB_email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTB_email_KeyDown);
            this.TXTB_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTB_email_KeyPress);
            // 
            // LBL_email
            // 
            this.LBL_email.AutoSize = true;
            this.LBL_email.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_email.Location = new System.Drawing.Point(8, 80);
            this.LBL_email.Name = "LBL_email";
            this.LBL_email.Size = new System.Drawing.Size(47, 19);
            this.LBL_email.TabIndex = 2;
            this.LBL_email.Text = "Email";
            // 
            // LBL_password
            // 
            this.LBL_password.AutoSize = true;
            this.LBL_password.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_password.Location = new System.Drawing.Point(8, 160);
            this.LBL_password.Name = "LBL_password";
            this.LBL_password.Size = new System.Drawing.Size(78, 19);
            this.LBL_password.TabIndex = 3;
            this.LBL_password.Text = "Password";
            // 
            // TXTB_password
            // 
            this.TXTB_password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTB_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTB_password.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTB_password.Location = new System.Drawing.Point(12, 195);
            this.TXTB_password.Name = "TXTB_password";
            this.TXTB_password.Size = new System.Drawing.Size(310, 27);
            this.TXTB_password.TabIndex = 4;
            this.TXTB_password.UseSystemPasswordChar = true;
            this.TXTB_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTB_password_KeyDown);
            this.TXTB_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTB_password_KeyPress);
            // 
            // BTN_login
            // 
            this.BTN_login.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(96)))), ((int)(((byte)(246)))));
            this.BTN_login.FlatAppearance.BorderSize = 0;
            this.BTN_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_login.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_login.ForeColor = System.Drawing.Color.White;
            this.BTN_login.Location = new System.Drawing.Point(107, 245);
            this.BTN_login.Name = "BTN_login";
            this.BTN_login.Size = new System.Drawing.Size(120, 35);
            this.BTN_login.TabIndex = 5;
            this.BTN_login.Text = "Login";
            this.BTN_login.UseVisualStyleBackColor = false;
            this.BTN_login.Click += new System.EventHandler(this.BTN_login_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 292);
            this.Controls.Add(this.BTN_login);
            this.Controls.Add(this.TXTB_password);
            this.Controls.Add(this.LBL_password);
            this.Controls.Add(this.LBL_email);
            this.Controls.Add(this.TXTB_email);
            this.Controls.Add(this.LBL_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_title;
        private System.Windows.Forms.TextBox TXTB_email;
        private System.Windows.Forms.Label LBL_email;
        private System.Windows.Forms.Label LBL_password;
        private System.Windows.Forms.TextBox TXTB_password;
        private System.Windows.Forms.Button BTN_login;
    }
}