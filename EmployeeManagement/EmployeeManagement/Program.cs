using System;
using System.Windows.Forms;

namespace EmployeeManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Make the application start by showing LohinForm first.
            LoginForm _login = new LoginForm();
            Application.Run(_login);

            // If the user signed in successfully it will proceed to the MainForm,
            // otherwise it will exit.
            if (_login.Authenticated)
                Application.Run(new MainForm());
        }
    }
}