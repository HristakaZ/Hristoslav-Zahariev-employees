﻿namespace EmployeePairFinder.Models
{
    public class Employee
    {
        public int EmpID { get; set; }

        public int ProjectID { get; set; }

        public DateTime DateFrom { get; set; }

        public DateTime? DateTo { get; set; }

        public Employee()
        {
            if (this.DateTo == null)
            {
                this.DateTo = DateTime.Now;
            }
        }
    }
}
