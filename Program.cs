
using System;
using System.Collections.Generic;

namespace EmployeePromotion_EasyCaseStudy
{
    class EmployeePromotion
    {
        public static Employee employee = new Employee();
        public static List<Employee> employeeList = new List<Employee>();
        public static string employeeNames;
        static void Main()
        {
            
            
            Console.WriteLine("Please enter the employee names in the order of their eligibility for promotion (Please enter blank to stop)");
            GetEmployeesDataFromUSer();


            OptimizeCollection();


            Console.WriteLine("Please enter the name of the employee to check promotion position");
            CheckPromotionPosition();


            Console.WriteLine("Promoted employee list:");
            employeeList.Sort(new EmployeeSortByName());
            foreach (var employe in employeeList)
            {
                Console.WriteLine(employe.Name);
            }

        }
        public static void GetEmployeesDataFromUSer()
        {
            
            do
            {
                employeeNames = Console.ReadLine();
                 if (employeeNames.Trim() == "" && employeeList.Count == 0) 
                {  
                    Console.WriteLine("Please enter atleast one employee name"); GetEmployeesDataFromUSer(); 
                }
                else
                {
                    employeeList.Add(new Employee { Name = employeeNames });
                }
            }
            while (employeeNames != "" && employeeList.Count != 0);
        }
        public static void OptimizeCollection()
        {
            employeeList.RemoveAt(employeeList.Count - 1);
            Console.WriteLine("The current size of the collection is " + employeeList.Capacity);
            employeeList.TrimExcess();
            Console.WriteLine("The size after removing the extra space is " + employeeList.Capacity);

            Console.WriteLine("\n");
        }
        public static void CheckPromotionPosition()
        {
            int promotionPosition=0;
            string checkEmployeeName;
            checkEmployeeName = Console.ReadLine();
            foreach (var employee in employeeList)
            {

                if (employee.Name == checkEmployeeName)
                {
                    promotionPosition = employeeList.IndexOf(employee) + 1;
                }

            }
            if (promotionPosition != 0)
            {
                Console.WriteLine("\" " + checkEmployeeName + " \"  is in the position " + promotionPosition + " for promotion.");
            }
            else
            {
                Console.WriteLine(checkEmployeeName + " is not an employee, kindly check with it and Reenter the correct Employee Name");
                CheckPromotionPosition();
            }
        }
    }
   
}
