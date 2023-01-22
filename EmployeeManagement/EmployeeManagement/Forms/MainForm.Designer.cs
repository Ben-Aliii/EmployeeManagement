namespace EmployeeManagement
{
    partial class MainForm
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
            this.LBL_search = new System.Windows.Forms.Label();
            this.TXTB_search = new System.Windows.Forms.TextBox();
            this.LV_employees = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BTN_add = new System.Windows.Forms.Button();
            this.BTN_update = new System.Windows.Forms.Button();
            this.BTN_delete = new System.Windows.Forms.Button();
            this.CB_searchby = new System.Windows.Forms.ComboBox();
            this.BTN_logout = new System.Windows.Forms.Button();
            this.LBL_page = new System.Windows.Forms.Label();
            this.BTN_nextpage = new System.Windows.Forms.Button();
            this.BTN_previouspage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_search
            // 
            this.LBL_search.AutoSize = true;
            this.LBL_search.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_search.Location = new System.Drawing.Point(118, 21);
            this.LBL_search.Name = "LBL_search";
            this.LBL_search.Size = new System.Drawing.Size(58, 19);
            this.LBL_search.TabIndex = 0;
            this.LBL_search.Text = "Search";
            // 
            // TXTB_search
            // 
            this.TXTB_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTB_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTB_search.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTB_search.Location = new System.Drawing.Point(182, 19);
            this.TXTB_search.Name = "TXTB_search";
            this.TXTB_search.Size = new System.Drawing.Size(236, 27);
            this.TXTB_search.TabIndex = 1;
            this.TXTB_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTB_search_KeyDown);
            this.TXTB_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTB_search_KeyPress);
            // 
            // LV_employees
            // 
            this.LV_employees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LV_employees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.LV_employees.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.LV_employees.FullRowSelect = true;
            this.LV_employees.Location = new System.Drawing.Point(12, 63);
            this.LV_employees.Name = "LV_employees";
            this.LV_employees.Size = new System.Drawing.Size(860, 445);
            this.LV_employees.TabIndex = 2;
            this.LV_employees.UseCompatibleStateImageBehavior = false;
            this.LV_employees.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "First Name";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Last Name";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Job Title";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Email";
            this.columnHeader4.Width = 250;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Is Admin";
            this.columnHeader5.Width = 100;
            // 
            // BTN_add
            // 
            this.BTN_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(96)))), ((int)(((byte)(246)))));
            this.BTN_add.FlatAppearance.BorderSize = 0;
            this.BTN_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_add.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.BTN_add.ForeColor = System.Drawing.Color.White;
            this.BTN_add.Location = new System.Drawing.Point(772, 19);
            this.BTN_add.Name = "BTN_add";
            this.BTN_add.Size = new System.Drawing.Size(100, 27);
            this.BTN_add.TabIndex = 6;
            this.BTN_add.Text = "Add";
            this.BTN_add.UseVisualStyleBackColor = false;
            this.BTN_add.Click += new System.EventHandler(this.BTN_add_Click);
            // 
            // BTN_update
            // 
            this.BTN_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(96)))), ((int)(((byte)(246)))));
            this.BTN_update.FlatAppearance.BorderSize = 0;
            this.BTN_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_update.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.BTN_update.ForeColor = System.Drawing.Color.White;
            this.BTN_update.Location = new System.Drawing.Point(666, 19);
            this.BTN_update.Name = "BTN_update";
            this.BTN_update.Size = new System.Drawing.Size(100, 27);
            this.BTN_update.TabIndex = 7;
            this.BTN_update.Text = "Edit";
            this.BTN_update.UseVisualStyleBackColor = false;
            this.BTN_update.Click += new System.EventHandler(this.BTN_update_Click);
            // 
            // BTN_delete
            // 
            this.BTN_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(96)))), ((int)(((byte)(246)))));
            this.BTN_delete.FlatAppearance.BorderSize = 0;
            this.BTN_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_delete.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.BTN_delete.ForeColor = System.Drawing.Color.White;
            this.BTN_delete.Location = new System.Drawing.Point(560, 19);
            this.BTN_delete.Name = "BTN_delete";
            this.BTN_delete.Size = new System.Drawing.Size(100, 27);
            this.BTN_delete.TabIndex = 8;
            this.BTN_delete.Text = "Delete";
            this.BTN_delete.UseVisualStyleBackColor = false;
            this.BTN_delete.Click += new System.EventHandler(this.BTN_delete_Click);
            // 
            // CB_searchby
            // 
            this.CB_searchby.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_searchby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_searchby.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.CB_searchby.FormattingEnabled = true;
            this.CB_searchby.Items.AddRange(new object[] {
            "By First Name",
            "By Last Name",
            "By Job Title",
            "By Email"});
            this.CB_searchby.Location = new System.Drawing.Point(424, 21);
            this.CB_searchby.Name = "CB_searchby";
            this.CB_searchby.Size = new System.Drawing.Size(130, 23);
            this.CB_searchby.TabIndex = 9;
            this.CB_searchby.SelectedIndexChanged += new System.EventHandler(this.CB_searchby_SelectedIndexChanged);
            // 
            // BTN_logout
            // 
            this.BTN_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(96)))), ((int)(((byte)(246)))));
            this.BTN_logout.FlatAppearance.BorderSize = 0;
            this.BTN_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_logout.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.BTN_logout.ForeColor = System.Drawing.Color.White;
            this.BTN_logout.Location = new System.Drawing.Point(12, 19);
            this.BTN_logout.Name = "BTN_logout";
            this.BTN_logout.Size = new System.Drawing.Size(100, 27);
            this.BTN_logout.TabIndex = 10;
            this.BTN_logout.Text = "Logout";
            this.BTN_logout.UseVisualStyleBackColor = false;
            this.BTN_logout.Click += new System.EventHandler(this.BTN_logout_Click);
            // 
            // LBL_page
            // 
            this.LBL_page.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_page.Location = new System.Drawing.Point(413, 525);
            this.LBL_page.Name = "LBL_page";
            this.LBL_page.Size = new System.Drawing.Size(75, 25);
            this.LBL_page.TabIndex = 11;
            this.LBL_page.Text = "0 / 0";
            this.LBL_page.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_nextpage
            // 
            this.BTN_nextpage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_nextpage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(96)))), ((int)(((byte)(246)))));
            this.BTN_nextpage.FlatAppearance.BorderSize = 0;
            this.BTN_nextpage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_nextpage.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.BTN_nextpage.ForeColor = System.Drawing.Color.White;
            this.BTN_nextpage.Location = new System.Drawing.Point(494, 525);
            this.BTN_nextpage.Name = "BTN_nextpage";
            this.BTN_nextpage.Size = new System.Drawing.Size(75, 25);
            this.BTN_nextpage.TabIndex = 12;
            this.BTN_nextpage.Text = "Next";
            this.BTN_nextpage.UseVisualStyleBackColor = false;
            this.BTN_nextpage.Click += new System.EventHandler(this.BTN_nextpage_Click);
            // 
            // BTN_previouspage
            // 
            this.BTN_previouspage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_previouspage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(96)))), ((int)(((byte)(246)))));
            this.BTN_previouspage.FlatAppearance.BorderSize = 0;
            this.BTN_previouspage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_previouspage.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.BTN_previouspage.ForeColor = System.Drawing.Color.White;
            this.BTN_previouspage.Location = new System.Drawing.Point(332, 525);
            this.BTN_previouspage.Name = "BTN_previouspage";
            this.BTN_previouspage.Size = new System.Drawing.Size(75, 25);
            this.BTN_previouspage.TabIndex = 13;
            this.BTN_previouspage.Text = "Previous";
            this.BTN_previouspage.UseVisualStyleBackColor = false;
            this.BTN_previouspage.Click += new System.EventHandler(this.BTN_previouspage_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.BTN_previouspage);
            this.Controls.Add(this.BTN_nextpage);
            this.Controls.Add(this.LBL_page);
            this.Controls.Add(this.BTN_logout);
            this.Controls.Add(this.CB_searchby);
            this.Controls.Add(this.BTN_delete);
            this.Controls.Add(this.BTN_update);
            this.Controls.Add(this.BTN_add);
            this.Controls.Add(this.LV_employees);
            this.Controls.Add(this.LBL_search);
            this.Controls.Add(this.TXTB_search);
            this.Name = "MainForm";
            this.Text = "Employee Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_search;
        private System.Windows.Forms.TextBox TXTB_search;
        private System.Windows.Forms.ListView LV_employees;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button BTN_add;
        private System.Windows.Forms.Button BTN_update;
        private System.Windows.Forms.Button BTN_delete;
        private System.Windows.Forms.ComboBox CB_searchby;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button BTN_logout;
        private System.Windows.Forms.Label LBL_page;
        private System.Windows.Forms.Button BTN_nextpage;
        private System.Windows.Forms.Button BTN_previouspage;
    }
}

