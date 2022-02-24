using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageOperation
{
    internal class EmployeeWage
    {
        public const int Is_Full_Time = 1;
        public const int Is_Part_Time = 2;
        public const int Emp_Rate_Per_Hour = 20;
        public const int Num_Working_Days = 20;
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
        //Use Switch case statement for Employee Wage
        public void IsPartTime()
        {
            int empCheck = random.Next(0, 2);
            switch (empCheck)
            {
                case Is_Part_Time:
                    EmpHours = 4;
                    break;
                case Is_Full_Time:
                    EmpHours = 8;
                    break;
                default:
                    EmpHours = 0;
                    break;
            }
            EmpWage = EmpHours * Emp_Rate_Per_Hour;
            Console.WriteLine("Employee Daily Wage using Switch case statement are:" + EmpWage);
        }

        //Calculating Employee Wage For Month
        //creating constant variable i.e Num_Working_Days
        public void TotalDays()
        {
            int EmpHour = 0;
            int EmpWage = 0;
            int totalEmpWage = 0;

            for (int day = 0; day < Num_Working_Days; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0,2);
                switch (empCheck)
                {
                    case Is_Part_Time:
                        EmpHour = 4;
                        break;
                    case Is_Full_Time:
                        EmpHour = 8;
                        break;
                    default:
                        EmpHour = 0;
                        break;
                }
                EmpWage = EmpHour * Num_Working_Days;
                totalEmpWage += EmpWage;
            }
            Console.WriteLine("Employee wage:" + EmpWage);
            Console.WriteLine("Total Employee Wage for month:" + totalEmpWage);
        }
    }
}
