namespace EmployeeManagement
{
    public class Employee
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
                return m_FirstName;
            }
        }
        public string LastName
        {
            get
            {
                return m_LastName;
            }
        }
        public string JobTitle
        {
            get
            {
                return m_JobTitle;
            }
        }
        public string Email
        {
            get
            {
                return m_Email;
            }
        }
        public int Role
        {
            get
            {
                return m_Role;
            }
        }
        public bool IsAdmin
        {
            get
            {
                return m_Role == 1;
            }
        }
        
        private int m_Id;
        private string m_FirstName;
        private string m_LastName;
        private string m_JobTitle;
        private string m_Email;
        private int m_Role;

        public Employee(int id, string firstname, string lastname, string jobtitle, string email, int role)
        {
            m_Id = id;
            m_FirstName = firstname;
            m_LastName = lastname;
            m_JobTitle = jobtitle;
            m_Email = email;
            m_Role = role;
        }
    }
}