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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.TXTB_firstname = new MaterialSkin.Controls.MaterialTextBox();
            this.TXTB_lastname = new MaterialSkin.Controls.MaterialTextBox();
            this.TXTB_jobtitle = new MaterialSkin.Controls.MaterialTextBox();
            this.TXTB_email = new MaterialSkin.Controls.MaterialTextBox();
            this.TXTB_password = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.BTN_cancel = new MaterialSkin.Controls.MaterialButton();
            this.BTN_add = new MaterialSkin.Controls.MaterialButton();
            this.CB_isadmin = new MaterialSkin.Controls.MaterialCheckbox();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(12, 82);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(78, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "First Name";
            // 
            // TXTB_firstname
            // 
            this.TXTB_firstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTB_firstname.Depth = 0;
            this.TXTB_firstname.Font = new System.Drawing.Font("Roboto", 12F);
            this.TXTB_firstname.Location = new System.Drawing.Point(110, 76);
            this.TXTB_firstname.MaxLength = 50;
            this.TXTB_firstname.MouseState = MaterialSkin.MouseState.OUT;
            this.TXTB_firstname.Multiline = false;
            this.TXTB_firstname.Name = "TXTB_firstname";
            this.TXTB_firstname.Size = new System.Drawing.Size(260, 36);
            this.TXTB_firstname.TabIndex = 1;
            this.TXTB_firstname.Text = "";
            this.TXTB_firstname.UseTallSize = false;
            this.TXTB_firstname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTB_firstname_KeyDown);
            this.TXTB_firstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTB_firstname_KeyPress);
            // 
            // TXTB_lastname
            // 
            this.TXTB_lastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTB_lastname.Depth = 0;
            this.TXTB_lastname.Font = new System.Drawing.Font("Roboto", 12F);
            this.TXTB_lastname.Location = new System.Drawing.Point(110, 136);
            this.TXTB_lastname.MaxLength = 50;
            this.TXTB_lastname.MouseState = MaterialSkin.MouseState.OUT;
            this.TXTB_lastname.Multiline = false;
            this.TXTB_lastname.Name = "TXTB_lastname";
            this.TXTB_lastname.Size = new System.Drawing.Size(260, 36);
            this.TXTB_lastname.TabIndex = 2;
            this.TXTB_lastname.Text = "";
            this.TXTB_lastname.UseTallSize = false;
            this.TXTB_lastname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTB_lastname_KeyDown);
            this.TXTB_lastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTB_lastname_KeyPress);
            // 
            // TXTB_jobtitle
            // 
            this.TXTB_jobtitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTB_jobtitle.Depth = 0;
            this.TXTB_jobtitle.Font = new System.Drawing.Font("Roboto", 12F);
            this.TXTB_jobtitle.Location = new System.Drawing.Point(110, 196);
            this.TXTB_jobtitle.MaxLength = 50;
            this.TXTB_jobtitle.MouseState = MaterialSkin.MouseState.OUT;
            this.TXTB_jobtitle.Multiline = false;
            this.TXTB_jobtitle.Name = "TXTB_jobtitle";
            this.TXTB_jobtitle.Size = new System.Drawing.Size(260, 36);
            this.TXTB_jobtitle.TabIndex = 3;
            this.TXTB_jobtitle.Text = "";
            this.TXTB_jobtitle.UseTallSize = false;
            this.TXTB_jobtitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTB_jobtitle_KeyDown);
            this.TXTB_jobtitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTB_jobtitle_KeyPress);
            // 
            // TXTB_email
            // 
            this.TXTB_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTB_email.Depth = 0;
            this.TXTB_email.Font = new System.Drawing.Font("Roboto", 12F);
            this.TXTB_email.Location = new System.Drawing.Point(110, 256);
            this.TXTB_email.MaxLength = 50;
            this.TXTB_email.MouseState = MaterialSkin.MouseState.OUT;
            this.TXTB_email.Multiline = false;
            this.TXTB_email.Name = "TXTB_email";
            this.TXTB_email.Size = new System.Drawing.Size(260, 36);
            this.TXTB_email.TabIndex = 4;
            this.TXTB_email.Text = "";
            this.TXTB_email.UseTallSize = false;
            this.TXTB_email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTB_email_KeyDown);
            this.TXTB_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTB_email_KeyPress);
            // 
            // TXTB_password
            // 
            this.TXTB_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTB_password.Depth = 0;
            this.TXTB_password.Font = new System.Drawing.Font("Roboto", 12F);
            this.TXTB_password.Location = new System.Drawing.Point(110, 316);
            this.TXTB_password.MaxLength = 50;
            this.TXTB_password.MouseState = MaterialSkin.MouseState.OUT;
            this.TXTB_password.Multiline = false;
            this.TXTB_password.Name = "TXTB_password";
            this.TXTB_password.Password = true;
            this.TXTB_password.Size = new System.Drawing.Size(260, 36);
            this.TXTB_password.TabIndex = 5;
            this.TXTB_password.Text = "";
            this.TXTB_password.UseTallSize = false;
            this.TXTB_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTB_password_KeyDown);
            this.TXTB_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTB_password_KeyPress);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(12, 139);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(78, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Last Name";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(12, 199);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(63, 19);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "Job Title";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(12, 259);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(41, 19);
            this.materialLabel4.TabIndex = 8;
            this.materialLabel4.Text = "Email";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(12, 319);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(71, 19);
            this.materialLabel5.TabIndex = 9;
            this.materialLabel5.Text = "Password";
            // 
            // BTN_cancel
            // 
            this.BTN_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_cancel.AutoSize = false;
            this.BTN_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTN_cancel.Depth = 0;
            this.BTN_cancel.DrawShadows = true;
            this.BTN_cancel.HighEmphasis = true;
            this.BTN_cancel.Icon = null;
            this.BTN_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_cancel.Location = new System.Drawing.Point(290, 395);
            this.BTN_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BTN_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTN_cancel.Name = "BTN_cancel";
            this.BTN_cancel.Size = new System.Drawing.Size(80, 40);
            this.BTN_cancel.TabIndex = 11;
            this.BTN_cancel.Text = "Cancel";
            this.BTN_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BTN_cancel.UseAccentColor = false;
            this.BTN_cancel.UseVisualStyleBackColor = true;
            this.BTN_cancel.Click += new System.EventHandler(this.BTN_cancel_Click);
            // 
            // BTN_add
            // 
            this.BTN_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_add.AutoSize = false;
            this.BTN_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTN_add.Depth = 0;
            this.BTN_add.DrawShadows = true;
            this.BTN_add.HighEmphasis = true;
            this.BTN_add.Icon = null;
            this.BTN_add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_add.Location = new System.Drawing.Point(202, 395);
            this.BTN_add.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BTN_add.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTN_add.Name = "BTN_add";
            this.BTN_add.Size = new System.Drawing.Size(80, 40);
            this.BTN_add.TabIndex = 10;
            this.BTN_add.Text = "Add";
            this.BTN_add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BTN_add.UseAccentColor = false;
            this.BTN_add.UseVisualStyleBackColor = true;
            this.BTN_add.Click += new System.EventHandler(this.BTN_add_Click);
            // 
            // CB_isadmin
            // 
            this.CB_isadmin.AutoSize = true;
            this.CB_isadmin.Depth = 0;
            this.CB_isadmin.Location = new System.Drawing.Point(5, 369);
            this.CB_isadmin.Margin = new System.Windows.Forms.Padding(0);
            this.CB_isadmin.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CB_isadmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.CB_isadmin.Name = "CB_isadmin";
            this.CB_isadmin.Ripple = true;
            this.CB_isadmin.Size = new System.Drawing.Size(97, 37);
            this.CB_isadmin.TabIndex = 12;
            this.CB_isadmin.Text = "Is Admin";
            this.CB_isadmin.UseVisualStyleBackColor = true;
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.CB_isadmin);
            this.Controls.Add(this.BTN_cancel);
            this.Controls.Add(this.BTN_add);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.TXTB_password);
            this.Controls.Add(this.TXTB_email);
            this.Controls.Add(this.TXTB_jobtitle);
            this.Controls.Add(this.TXTB_lastname);
            this.Controls.Add(this.TXTB_firstname);
            this.Controls.Add(this.materialLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEmployeeForm";
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox TXTB_firstname;
        private MaterialSkin.Controls.MaterialTextBox TXTB_lastname;
        private MaterialSkin.Controls.MaterialTextBox TXTB_jobtitle;
        private MaterialSkin.Controls.MaterialTextBox TXTB_email;
        private MaterialSkin.Controls.MaterialTextBox TXTB_password;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialButton BTN_cancel;
        private MaterialSkin.Controls.MaterialButton BTN_add;
        private MaterialSkin.Controls.MaterialCheckbox CB_isadmin;
    }
}