using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeWage empWage = new EmployeeWage();
            Console.WriteLine("******Monthly Employee Wage******");
            Console.WriteLine("Welcome to Empolyee Wage Computation Program\n");

            empWage.AddCompanyEmpWageToList("Google", 10, 4, 20);
            empWage.AddCompanyEmpWageToList("Microsoft", 20, 5, 20);
            empWage.AddCompanyEmpWageToList("Deloitte", 30, 3, 30);
            empWage.ComputeEmpWage();

            //empWage.CompanyDetails("TCS",10,8);
            Console.ReadKey();
        }
    }
}
