using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageOperation
{
    internal class EmployeeWage
    {
        int Is_Full_Time = 1;
        int Is_Part_Time = 2;
        Random random = new Random();
        public void operation()
        {
            int empCheck = random.Next(0, 2);
            if (empCheck == Is_Full_Time)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }

        }
        //Checking Employee Daily Wage
        int Emp_Rate_Per_Hour = 20;
        int EmpHours = 0;
        int EmpWage = 0;
        public void DailyWage()
        {
            int empCheck = random.Next(0, 2);
            if (empCheck == Is_Full_Time)
            {
                EmpHours = 8;
            }
            else
            {
                EmpHours = 0;
            }
            EmpWage = EmpHours * Emp_Rate_Per_Hour;
            Console.WriteLine("Employee Daily Wage are:" + EmpWage);
        }

        // Checking Employee is Part Time or not
        public void PartTime()
        {
            int empCheck = random.Next(0, 2);
            if (empCheck == Is_Full_Time)
            {
                EmpHours = 8;
            }
            else if (empCheck == Is_Part_Time)
            {
                EmpHours = 4;
            }
            else
            {
                EmpHours = 0;
            }
            EmpWage = EmpHours * Emp_Rate_Per_Hour;
            Console.WriteLine("Employee Daily Wage are :" + EmpWage);
        }
    }
}
