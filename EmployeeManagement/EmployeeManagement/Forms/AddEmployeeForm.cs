using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace EmployeeManagement
{
    public partial class AddEmployeeForm : MaterialForm
    {
        public int Id
        {
            get
            {
                return m_Id;
            }
        }
        public string FirstName
        {
            get
            {
                return TXTB_firstname.Text;
            }
        }
        public string LastName
        {
            get
            {
                return TXTB_lastname.Text;
            }
        }
        public string JobTitle
        {
            get
            {
                return TXTB_jobtitle.Text;
            }
        }
        public string Email
        {
            get
            {
                return TXTB_email.Text;
            }
        }
        public string Password
        {
            get
            {
                return TXTB_password.Text;
            }
        }
        public bool IsAdmin
        {
            get
            {
                return CB_isadmin.Checked;
            }
        }

        private int m_Id;

        public AddEmployeeForm()
        {
            InitializeComponent();
            Initialize();
        }

        public AddEmployeeForm(Employee employee)
        {
            InitializeComponent();
            if (employee != null)
            {
                m_Id = employee.Id;
                TXTB_firstname.Text = employee.FirstName;
                TXTB_lastname.Text = employee.LastName;
                TXTB_jobtitle.Text = employee.JobTitle;
                TXTB_email.Text = employee.Email;
                CB_isadmin.Checked = employee.IsAdmin;
                Text = "Edit Employee";
                BTN_add.Text = "Update";
            }
        }

        #region ui event methods

        private void BTN_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BTN_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TXTB_firstname.Text))
            {
                MessageBox.Show("First Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(TXTB_lastname.Text))
            {
                MessageBox.Show("Last Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(TXTB_jobtitle.Text))
            {
                MessageBox.Show("Job Title cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(TXTB_email.Text))
            {
                MessageBox.Show("Email cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(TXTB_password.Text))
            {
                MessageBox.Show("Password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!EmailUtility.IsValid(TXTB_email.Text))
            {
                MessageBox.Show("Email is invalid. Enter a valid email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void TXTB_firstname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                TXTB_lastname.Focus();
            }
        }

        private void TXTB_firstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
                e.Handled = true;
        }

        private void TXTB_lastname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                TXTB_jobtitle.Focus();
            }
        }

        private void TXTB_lastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
                e.Handled = true;
        }

        private void TXTB_jobtitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                TXTB_email.Focus();
            }
        }

        private void TXTB_jobtitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
                e.Handled = true;
        }

        private void TXTB_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                TXTB_password.Focus();
            }
        }

        private void TXTB_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
                e.Handled = true;
        }

        private void TXTB_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.Handled = true;
        }

        private void TXTB_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
                e.Handled = true;
        }

        #endregion

        #region private methods

        private void Initialize()
        {
            MaterialSkinManager.Instance.EnforceBackcolorOnAllComponents = true;
            MaterialSkinManager.Instance.AddFormToManage(this);
            MaterialSkinManager.Instance.Theme = MaterialSkinManager.Themes.LIGHT;
            MaterialSkinManager.Instance.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
        }

        #endregion
    }
}