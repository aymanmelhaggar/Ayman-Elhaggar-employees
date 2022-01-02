using System;

namespace SirmaSolution.PairEmployees
{
    public class Employee
    {
        public string EmpID { get; set; }
        public string ProjectID { get; set; }
        public DateTime DateFrom { get; set; } = DateTime.Now.Date;
        public DateTime DateTo { get; set; } = DateTime.Now.Date;
    }
}
