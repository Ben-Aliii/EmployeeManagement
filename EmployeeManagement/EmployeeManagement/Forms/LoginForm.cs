using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace EmployeeManagement
{
    public partial class LoginForm : MaterialForm
    {
        public bool Authenticated
        {
            get
            {
                return m_Authenticated;
            }
        }

        private bool m_Authenticated = false;

        public LoginForm()
        {
            InitializeComponent();
            Initialize();
            //TXTB_email.Text = "admintest@gmail.com";
            //TXTB_password.Text = "123four";
        }

        #region ui event methods

        private void BTN_login_Click(object sender, EventArgs e)
        {
            Login();
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
            {
                e.Handled = true;
                Login();
            }
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
            //MaterialSkinManager.Instance.AddFormToManage(this);
            MaterialSkinManager.Instance.Theme = MaterialSkinManager.Themes.LIGHT;
            MaterialSkinManager.Instance.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
            LBL_title.Font = new Font("Microsoft YaHei UI", 15.0f, FontStyle.Regular);
            LBL_title.ForeColor = Color.DimGray;
        }

        private async void Login()
        {
            // Validity checks.
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

            // Make the POST request
            bool _result = await EmployeeManager.Login(TXTB_email.Text, TXTB_password.Text);
            if (_result)
            {
                m_Authenticated = true;
                Close();
            }
        }

        #endregion
    }
}