namespace EmployeeManagement
{
    partial class AddEmployeeForm
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
            this.LBL_firstname = new System.Windows.Forms.Label();
            this.TXTB_firstname = new System.Windows.Forms.TextBox();
            this.LBL_lastname = new System.Windows.Forms.Label();
            this.TXTB_lastname = new System.Windows.Forms.TextBox();
            this.TXTB_jobtitle = new System.Windows.Forms.TextBox();
            this.TXTB_email = new System.Windows.Forms.TextBox();
            this.LBL_jobtitle = new System.Windows.Forms.Label();
            this.LBL_email = new System.Windows.Forms.Label();
            this.LBL_password = new System.Windows.Forms.Label();
            this.TXTB_password = new System.Windows.Forms.TextBox();
            this.CB_isadmin = new System.Windows.Forms.CheckBox();
            this.BTN_cancel = new System.Windows.Forms.Button();
            this.BTN_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_firstname
            // 
            this.LBL_firstname.AutoSize = true;
            this.LBL_firstname.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.LBL_firstname.Location = new System.Drawing.Point(12, 22);
            this.LBL_firstname.Name = "LBL_firstname";
            this.LBL_firstname.Size = new System.Drawing.Size(79, 18);
            this.LBL_firstname.TabIndex = 2;
            this.LBL_firstname.Text = "First Name";
            // 
            // TXTB_firstname
            // 
            this.TXTB_firstname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTB_firstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTB_firstname.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.TXTB_firstname.Location = new System.Drawing.Point(105, 20);
            this.TXTB_firstname.Name = "TXTB_firstname";
            this.TXTB_firstname.Size = new System.Drawing.Size(287, 24);
            this.TXTB_firstname.TabIndex = 3;
            this.TXTB_firstname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTB_firstname_KeyDown);
            this.TXTB_firstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTB_firstname_KeyPress);
            // 
            // LBL_lastname
            // 
            this.LBL_lastname.AutoSize = true;
            this.LBL_lastname.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.LBL_lastname.Location = new System.Drawing.Point(12, 67);
            this.LBL_lastname.Name = "LBL_lastname";
            this.LBL_lastname.Size = new System.Drawing.Size(78, 18);
            this.LBL_lastname.TabIndex = 4;
            this.LBL_lastname.Text = "Last Name";
            // 
            // TXTB_lastname
            // 
            this.TXTB_lastname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTB_lastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTB_lastname.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.TXTB_lastname.Location = new System.Drawing.Point(105, 65);
            this.TXTB_lastname.Name = "TXTB_lastname";
            this.TXTB_lastname.Size = new System.Drawing.Size(287, 24);
            this.TXTB_lastname.TabIndex = 5;
            this.TXTB_lastname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTB_lastname_KeyDown);
            this.TXTB_lastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTB_lastname_KeyPress);
            // 
            // TXTB_jobtitle
            // 
            this.TXTB_jobtitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTB_jobtitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTB_jobtitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.TXTB_jobtitle.Location = new System.Drawing.Point(105, 110);
            this.TXTB_jobtitle.Name = "TXTB_jobtitle";
            this.TXTB_jobtitle.Size = new System.Drawing.Size(287, 24);
            this.TXTB_jobtitle.TabIndex = 6;
            this.TXTB_jobtitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTB_jobtitle_KeyDown);
            this.TXTB_jobtitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTB_jobtitle_KeyPress);
            // 
            // TXTB_email
            // 
            this.TXTB_email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTB_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTB_email.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.TXTB_email.Location = new System.Drawing.Point(105, 155);
            this.TXTB_email.Name = "TXTB_email";
            this.TXTB_email.Size = new System.Drawing.Size(287, 24);
            this.TXTB_email.TabIndex = 7;
            this.TXTB_email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTB_email_KeyDown);
            this.TXTB_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTB_email_KeyPress);
            // 
            // LBL_jobtitle
            // 
            this.LBL_jobtitle.AutoSize = true;
            this.LBL_jobtitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.LBL_jobtitle.Location = new System.Drawing.Point(12, 112);
            this.LBL_jobtitle.Name = "LBL_jobtitle";
            this.LBL_jobtitle.Size = new System.Drawing.Size(65, 18);
            this.LBL_jobtitle.TabIndex = 8;
            this.LBL_jobtitle.Text = "Job Title";
            // 
            // LBL_email
            // 
            this.LBL_email.AutoSize = true;
            this.LBL_email.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.LBL_email.Location = new System.Drawing.Point(12, 157);
            this.LBL_email.Name = "LBL_email";
            this.LBL_email.Size = new System.Drawing.Size(45, 18);
            this.LBL_email.TabIndex = 9;
            this.LBL_email.Text = "Email";
            // 
            // LBL_password
            // 
            this.LBL_password.AutoSize = true;
            this.LBL_password.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.LBL_password.Location = new System.Drawing.Point(12, 202);
            this.LBL_password.Name = "LBL_password";
            this.LBL_password.Size = new System.Drawing.Size(71, 18);
            this.LBL_password.TabIndex = 10;
            this.LBL_password.Text = "Password";
            // 
            // TXTB_password
            // 
            this.TXTB_password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTB_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTB_password.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.TXTB_password.Location = new System.Drawing.Point(105, 200);
            this.TXTB_password.Name = "TXTB_password";
            this.TXTB_password.Size = new System.Drawing.Size(287, 24);
            this.TXTB_password.TabIndex = 11;
            this.TXTB_password.UseSystemPasswordChar = true;
            this.TXTB_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTB_password_KeyDown);
            this.TXTB_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTB_password_KeyPress);
            // 
            // CB_isadmin
            // 
            this.CB_isadmin.AutoSize = true;
            this.CB_isadmin.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.CB_isadmin.Location = new System.Drawing.Point(105, 245);
            this.CB_isadmin.Name = "CB_isadmin";
            this.CB_isadmin.Size = new System.Drawing.Size(86, 22);
            this.CB_isadmin.TabIndex = 12;
            this.CB_isadmin.Text = "Is Admin";
            this.CB_isadmin.UseVisualStyleBackColor = true;
            // 
            // BTN_cancel
            // 
            this.BTN_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(96)))), ((int)(((byte)(246)))));
            this.BTN_cancel.FlatAppearance.BorderSize = 0;
            this.BTN_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_cancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.BTN_cancel.ForeColor = System.Drawing.Color.White;
            this.BTN_cancel.Location = new System.Drawing.Point(292, 293);
            this.BTN_cancel.Name = "BTN_cancel";
            this.BTN_cancel.Size = new System.Drawing.Size(100, 27);
            this.BTN_cancel.TabIndex = 13;
            this.BTN_cancel.Text = "Cancel";
            this.BTN_cancel.UseVisualStyleBackColor = false;
            this.BTN_cancel.Click += new System.EventHandler(this.BTN_cancel_Click);
            // 
            // BTN_add
            // 
            this.BTN_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(96)))), ((int)(((byte)(246)))));
            this.BTN_add.FlatAppearance.BorderSize = 0;
            this.BTN_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_add.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.BTN_add.ForeColor = System.Drawing.Color.White;
            this.BTN_add.Location = new System.Drawing.Point(186, 293);
            this.BTN_add.Name = "BTN_add";
            this.BTN_add.Size = new System.Drawing.Size(100, 27);
            this.BTN_add.TabIndex = 14;
            this.BTN_add.Text = "Add";
            this.BTN_add.UseVisualStyleBackColor = false;
            this.BTN_add.Click += new System.EventHandler(this.BTN_add_Click);
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 332);
            this.Controls.Add(this.BTN_add);
            this.Controls.Add(this.BTN_cancel);
            this.Controls.Add(this.CB_isadmin);
            this.Controls.Add(this.TXTB_password);
            this.Controls.Add(this.LBL_password);
            this.Controls.Add(this.LBL_email);
            this.Controls.Add(this.LBL_jobtitle);
            this.Controls.Add(this.TXTB_email);
            this.Controls.Add(this.TXTB_jobtitle);
            this.Controls.Add(this.TXTB_lastname);
            this.Controls.Add(this.LBL_lastname);
            this.Controls.Add(this.LBL_firstname);
            this.Controls.Add(this.TXTB_firstname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEmployeeForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_firstname;
        private System.Windows.Forms.TextBox TXTB_firstname;
        private System.Windows.Forms.Label LBL_lastname;
        private System.Windows.Forms.TextBox TXTB_lastname;
        private System.Windows.Forms.TextBox TXTB_jobtitle;
        private System.Windows.Forms.TextBox TXTB_email;
        private System.Windows.Forms.Label LBL_jobtitle;
        private System.Windows.Forms.Label LBL_email;
        private System.Windows.Forms.Label LBL_password;
        private System.Windows.Forms.TextBox TXTB_password;
        private System.Windows.Forms.CheckBox CB_isadmin;
        private System.Windows.Forms.Button BTN_cancel;
        private System.Windows.Forms.Button BTN_add;
    }
}