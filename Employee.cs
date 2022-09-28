using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tasks
{
    internal class Employee
    {
        public static void Main()
        {
            Console.WriteLine("Employee Details are");
            Console.WriteLine("**********************");

            employeedetails();
        

        }
        public static void employeedetails()
        {
            Console.WriteLine("Enter the Employee ID");
            int empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            string empname = Console.ReadLine();
            Console.WriteLine("Enter department");
            string dep = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            int salary = Convert.ToInt32(Console.ReadLine());
            Employee e = new Employee();
            e.employeeprint(empid,empname,dep,salary);
            Console.ReadLine();


        }

        public void employeeprint(int empid, string empname,string dep,int salary)
        {
            Console.WriteLine("Employee ID is " + empid);
            Console.WriteLine("Employee Name is " + empname);
            Console.WriteLine("Employee department " + dep);
            Console.WriteLine("Employee Salary is " + salary);
            Console.ReadLine();
        }


    }
}
