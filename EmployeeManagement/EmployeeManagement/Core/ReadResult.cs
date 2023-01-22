using System.Collections.Generic;

namespace EmployeeManagement
{
    public class ReadResult
    {
        public int TotalePageCount { get; set; }
        public List<Employee> Employees { get; set; }
    }
}