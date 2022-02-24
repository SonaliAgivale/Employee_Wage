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
            empWage.MonthlyWage();
            Console.ReadKey();
        }
    }
}
