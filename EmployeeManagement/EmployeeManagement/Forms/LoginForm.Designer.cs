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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.BTN_login = new MaterialSkin.Controls.MaterialButton();
            this.TXTB_email = new MaterialSkin.Controls.MaterialTextBox();
            this.TXTB_password = new MaterialSkin.Controls.MaterialTextBox();
            this.PB_icon = new System.Windows.Forms.PictureBox();
            this.LBL_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_login
            // 
            this.BTN_login.AutoSize = false;
            this.BTN_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTN_login.Depth = 0;
            this.BTN_login.DrawShadows = true;
            this.BTN_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_login.HighEmphasis = true;
            this.BTN_login.Icon = null;
            this.BTN_login.Location = new System.Drawing.Point(115, 344);
            this.BTN_login.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BTN_login.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTN_login.Name = "BTN_login";
            this.BTN_login.Size = new System.Drawing.Size(150, 36);
            this.BTN_login.TabIndex = 2;
            this.BTN_login.Text = "Login";
            this.BTN_login.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BTN_login.UseAccentColor = false;
            this.BTN_login.UseVisualStyleBackColor = true;
            this.BTN_login.Click += new System.EventHandler(this.BTN_login_Click);
            // 
            // TXTB_email
            // 
            this.TXTB_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTB_email.Depth = 0;
            this.TXTB_email.Font = new System.Drawing.Font("Roboto", 12F);
            this.TXTB_email.Hint = "Email";
            this.TXTB_email.Location = new System.Drawing.Point(40, 190);
            this.TXTB_email.MaxLength = 50;
            this.TXTB_email.MouseState = MaterialSkin.MouseState.OUT;
            this.TXTB_email.Multiline = false;
            this.TXTB_email.Name = "TXTB_email";
            this.TXTB_email.Size = new System.Drawing.Size(300, 50);
            this.TXTB_email.TabIndex = 0;
            this.TXTB_email.Text = "";
            this.TXTB_email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTB_email_KeyDown);
            this.TXTB_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTB_email_KeyPress);
            // 
            // TXTB_password
            // 
            this.TXTB_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTB_password.Depth = 0;
            this.TXTB_password.Font = new System.Drawing.Font("Roboto", 12F);
            this.TXTB_password.Hint = "Password";
            this.TXTB_password.Location = new System.Drawing.Point(40, 261);
            this.TXTB_password.MaxLength = 50;
            this.TXTB_password.MouseState = MaterialSkin.MouseState.OUT;
            this.TXTB_password.Multiline = false;
            this.TXTB_password.Name = "TXTB_password";
            this.TXTB_password.Password = true;
            this.TXTB_password.Size = new System.Drawing.Size(300, 50);
            this.TXTB_password.TabIndex = 1;
            this.TXTB_password.Text = "";
            this.TXTB_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTB_password_KeyDown);
            this.TXTB_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTB_password_KeyPress);
            // 
            // PB_icon
            // 
            this.PB_icon.Image = ((System.Drawing.Image)(resources.GetObject("PB_icon.Image")));
            this.PB_icon.Location = new System.Drawing.Point(158, 80);
            this.PB_icon.Name = "PB_icon";
            this.PB_icon.Size = new System.Drawing.Size(64, 64);
            this.PB_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PB_icon.TabIndex = 4;
            this.PB_icon.TabStop = false;
            // 
            // LBL_title
            // 
            this.LBL_title.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_title.ForeColor = System.Drawing.Color.DimGray;
            this.LBL_title.Location = new System.Drawing.Point(40, 147);
            this.LBL_title.Name = "LBL_title";
            this.LBL_title.Size = new System.Drawing.Size(300, 40);
            this.LBL_title.TabIndex = 5;
            this.LBL_title.Text = "Login to Your Account";
            this.LBL_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 430);
            this.Controls.Add(this.LBL_title);
            this.Controls.Add(this.PB_icon);
            this.Controls.Add(this.TXTB_password);
            this.Controls.Add(this.TXTB_email);
            this.Controls.Add(this.BTN_login);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.PB_icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton BTN_login;
        private MaterialSkin.Controls.MaterialTextBox TXTB_email;
        private MaterialSkin.Controls.MaterialTextBox TXTB_password;
        private System.Windows.Forms.PictureBox PB_icon;
        private System.Windows.Forms.Label LBL_title;
    }
}

