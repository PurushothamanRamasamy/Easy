using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePromotion_EasyCaseStudy
{
    public class Employee
    {
        int promotionPosition;
        public string Name
        {
            get;
            set;
        }
        

    }

    class EmployeeSortByName : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
