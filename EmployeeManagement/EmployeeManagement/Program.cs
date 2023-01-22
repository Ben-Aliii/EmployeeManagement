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
            LoginForm _login;
            MainForm _main;
            do
            {
                _login = new LoginForm();
                _main = new MainForm();

                // Make the application start by showing LoginForm first.
                Application.Run(_login);

                // If the user signed in successfully it will procceed to the MainForm,
                // otherwise it will exit.
                if (_login.Authenticated)
                    Application.Run(_main);
            } while (_main.LoggingOut);
        }
    }
}