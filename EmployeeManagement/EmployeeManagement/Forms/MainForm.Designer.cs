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
            this.BTN_logout = new MaterialSkin.Controls.MaterialButton();
            this.BTN_add = new MaterialSkin.Controls.MaterialButton();
            this.BTN_edit = new MaterialSkin.Controls.MaterialButton();
            this.BTN_delete = new MaterialSkin.Controls.MaterialButton();
            this.TXTB_search = new MaterialSkin.Controls.MaterialTextBox();
            this.CB_searchmethod = new MaterialSkin.Controls.MaterialComboBox();
            this.LV_employees = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LBL_page = new MaterialSkin.Controls.MaterialLabel();
            this.BTN_next = new MaterialSkin.Controls.MaterialButton();
            this.BTN_previous = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // BTN_logout
            // 
            this.BTN_logout.AutoSize = false;
            this.BTN_logout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTN_logout.Depth = 0;
            this.BTN_logout.DrawShadows = true;
            this.BTN_logout.HighEmphasis = true;
            this.BTN_logout.Icon = null;
            this.BTN_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_logout.Location = new System.Drawing.Point(8, 70);
            this.BTN_logout.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BTN_logout.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTN_logout.Name = "BTN_logout";
            this.BTN_logout.Size = new System.Drawing.Size(100, 40);
            this.BTN_logout.TabIndex = 0;
            this.BTN_logout.Text = "Logout";
            this.BTN_logout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BTN_logout.UseAccentColor = false;
            this.BTN_logout.UseVisualStyleBackColor = true;
            this.BTN_logout.Click += new System.EventHandler(this.BTN_logout_Click);
            // 
            // BTN_add
            // 
            this.BTN_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_add.AutoSize = false;
            this.BTN_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTN_add.Depth = 0;
            this.BTN_add.DrawShadows = true;
            this.BTN_add.HighEmphasis = true;
            this.BTN_add.Icon = null;
            this.BTN_add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_add.Location = new System.Drawing.Point(812, 70);
            this.BTN_add.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BTN_add.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTN_add.Name = "BTN_add";
            this.BTN_add.Size = new System.Drawing.Size(80, 40);
            this.BTN_add.TabIndex = 1;
            this.BTN_add.Text = "Add";
            this.BTN_add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BTN_add.UseAccentColor = false;
            this.BTN_add.UseVisualStyleBackColor = true;
            this.BTN_add.Click += new System.EventHandler(this.BTN_add_Click);
            // 
            // BTN_edit
            // 
            this.BTN_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_edit.AutoSize = false;
            this.BTN_edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTN_edit.Depth = 0;
            this.BTN_edit.DrawShadows = true;
            this.BTN_edit.HighEmphasis = true;
            this.BTN_edit.Icon = null;
            this.BTN_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_edit.Location = new System.Drawing.Point(724, 70);
            this.BTN_edit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BTN_edit.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTN_edit.Name = "BTN_edit";
            this.BTN_edit.Size = new System.Drawing.Size(80, 40);
            this.BTN_edit.TabIndex = 2;
            this.BTN_edit.Text = "Edit";
            this.BTN_edit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BTN_edit.UseAccentColor = false;
            this.BTN_edit.UseVisualStyleBackColor = true;
            this.BTN_edit.Click += new System.EventHandler(this.BTN_edit_Click);
            // 
            // BTN_delete
            // 
            this.BTN_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_delete.AutoSize = false;
            this.BTN_delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTN_delete.Depth = 0;
            this.BTN_delete.DrawShadows = true;
            this.BTN_delete.HighEmphasis = true;
            this.BTN_delete.Icon = null;
            this.BTN_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_delete.Location = new System.Drawing.Point(636, 70);
            this.BTN_delete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BTN_delete.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTN_delete.Name = "BTN_delete";
            this.BTN_delete.Size = new System.Drawing.Size(80, 40);
            this.BTN_delete.TabIndex = 3;
            this.BTN_delete.Text = "Delete";
            this.BTN_delete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BTN_delete.UseAccentColor = false;
            this.BTN_delete.UseVisualStyleBackColor = true;
            this.BTN_delete.Click += new System.EventHandler(this.BTN_delete_Click);
            // 
            // TXTB_search
            // 
            this.TXTB_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTB_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTB_search.Depth = 0;
            this.TXTB_search.Font = new System.Drawing.Font("Roboto", 12F);
            this.TXTB_search.Hint = "Search";
            this.TXTB_search.Location = new System.Drawing.Point(115, 74);
            this.TXTB_search.MaxLength = 50;
            this.TXTB_search.MouseState = MaterialSkin.MouseState.OUT;
            this.TXTB_search.Multiline = false;
            this.TXTB_search.Name = "TXTB_search";
            this.TXTB_search.Size = new System.Drawing.Size(358, 36);
            this.TXTB_search.TabIndex = 4;
            this.TXTB_search.Text = "";
            this.TXTB_search.UseTallSize = false;
            this.TXTB_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTB_search_KeyDown);
            this.TXTB_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTB_search_KeyPress);
            // 
            // CB_searchmethod
            // 
            this.CB_searchmethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_searchmethod.AutoResize = false;
            this.CB_searchmethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CB_searchmethod.Depth = 0;
            this.CB_searchmethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CB_searchmethod.DropDownHeight = 118;
            this.CB_searchmethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_searchmethod.DropDownWidth = 121;
            this.CB_searchmethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CB_searchmethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CB_searchmethod.FormattingEnabled = true;
            this.CB_searchmethod.IntegralHeight = false;
            this.CB_searchmethod.ItemHeight = 29;
            this.CB_searchmethod.Items.AddRange(new object[] {
            "By First Name",
            "By Last Name",
            "By Job Title",
            "By Email"});
            this.CB_searchmethod.Location = new System.Drawing.Point(479, 74);
            this.CB_searchmethod.MaxDropDownItems = 4;
            this.CB_searchmethod.MouseState = MaterialSkin.MouseState.OUT;
            this.CB_searchmethod.Name = "CB_searchmethod";
            this.CB_searchmethod.Size = new System.Drawing.Size(150, 35);
            this.CB_searchmethod.StartIndex = 0;
            this.CB_searchmethod.TabIndex = 5;
            this.CB_searchmethod.UseTallSize = false;
            this.CB_searchmethod.SelectedIndexChanged += new System.EventHandler(this.CB_searchby_SelectedIndexChanged);
            // 
            // LV_employees
            // 
            this.LV_employees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LV_employees.AutoSizeTable = false;
            this.LV_employees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LV_employees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LV_employees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.LV_employees.Depth = 0;
            this.LV_employees.FullRowSelect = true;
            this.LV_employees.Location = new System.Drawing.Point(12, 119);
            this.LV_employees.MinimumSize = new System.Drawing.Size(200, 100);
            this.LV_employees.MouseLocation = new System.Drawing.Point(-1, -1);
            this.LV_employees.MouseState = MaterialSkin.MouseState.OUT;
            this.LV_employees.Name = "LV_employees";
            this.LV_employees.OwnerDraw = true;
            this.LV_employees.Size = new System.Drawing.Size(880, 438);
            this.LV_employees.TabIndex = 6;
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
            this.columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Email";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Is Admin";
            this.columnHeader5.Width = 100;
            // 
            // LBL_page
            // 
            this.LBL_page.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LBL_page.Depth = 0;
            this.LBL_page.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LBL_page.Location = new System.Drawing.Point(400, 565);
            this.LBL_page.MouseState = MaterialSkin.MouseState.HOVER;
            this.LBL_page.Name = "LBL_page";
            this.LBL_page.Size = new System.Drawing.Size(100, 25);
            this.LBL_page.TabIndex = 7;
            this.LBL_page.Text = "0 / 0";
            this.LBL_page.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_next
            // 
            this.BTN_next.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_next.AutoSize = false;
            this.BTN_next.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTN_next.Depth = 0;
            this.BTN_next.DrawShadows = true;
            this.BTN_next.HighEmphasis = true;
            this.BTN_next.Icon = null;
            this.BTN_next.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_next.Location = new System.Drawing.Point(507, 566);
            this.BTN_next.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BTN_next.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTN_next.Name = "BTN_next";
            this.BTN_next.Size = new System.Drawing.Size(80, 25);
            this.BTN_next.TabIndex = 8;
            this.BTN_next.Text = "Next";
            this.BTN_next.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BTN_next.UseAccentColor = false;
            this.BTN_next.UseVisualStyleBackColor = true;
            this.BTN_next.Click += new System.EventHandler(this.BTN_next_Click);
            // 
            // BTN_previous
            // 
            this.BTN_previous.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_previous.AutoSize = false;
            this.BTN_previous.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTN_previous.Depth = 0;
            this.BTN_previous.DrawShadows = true;
            this.BTN_previous.HighEmphasis = true;
            this.BTN_previous.Icon = null;
            this.BTN_previous.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_previous.Location = new System.Drawing.Point(313, 565);
            this.BTN_previous.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BTN_previous.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTN_previous.Name = "BTN_previous";
            this.BTN_previous.Size = new System.Drawing.Size(80, 25);
            this.BTN_previous.TabIndex = 9;
            this.BTN_previous.Text = "Previous";
            this.BTN_previous.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BTN_previous.UseAccentColor = false;
            this.BTN_previous.UseVisualStyleBackColor = true;
            this.BTN_previous.Click += new System.EventHandler(this.BTN_previous_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.BTN_previous);
            this.Controls.Add(this.BTN_next);
            this.Controls.Add(this.LBL_page);
            this.Controls.Add(this.LV_employees);
            this.Controls.Add(this.CB_searchmethod);
            this.Controls.Add(this.TXTB_search);
            this.Controls.Add(this.BTN_delete);
            this.Controls.Add(this.BTN_edit);
            this.Controls.Add(this.BTN_add);
            this.Controls.Add(this.BTN_logout);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Management";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton BTN_logout;
        private MaterialSkin.Controls.MaterialButton BTN_add;
        private MaterialSkin.Controls.MaterialButton BTN_edit;
        private MaterialSkin.Controls.MaterialButton BTN_delete;
        private MaterialSkin.Controls.MaterialTextBox TXTB_search;
        private MaterialSkin.Controls.MaterialComboBox CB_searchmethod;
        private MaterialSkin.Controls.MaterialListView LV_employees;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private MaterialSkin.Controls.MaterialLabel LBL_page;
        private MaterialSkin.Controls.MaterialButton BTN_next;
        private MaterialSkin.Controls.MaterialButton BTN_previous;
    }
}