using System;
using System.Net.Mail;

namespace EmployeeManagement
{
    public static class EmailUtility
    {
        // A utlity method to check if the email is valid.
        public static bool IsValid(string email)
        {
            try
            {
                MailAddress _mail = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}