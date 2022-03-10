using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageOperation
{
    internal class EmployeeWage
    {
        public const int EMP_FULLTIME = 1, EMP_PARTTIME = 2;

        private List<CompanyWage> companyEmpWageList;

        public static Random random = new Random();

        public EmployeeWage()
        {
            companyEmpWageList = new List<CompanyWage>();
        }

        //Manage multiple companies using list
        public void AddCompanyEmpWageToList(string company, int emp_Wage_Per_Hr, int working_Days_Per_Month, int max_Hrs_Per_Month)
        {
            CompanyWage companyEmpWage = new CompanyWage(company, emp_Wage_Per_Hr, working_Days_Per_Month, max_Hrs_Per_Month);
            companyEmpWageList.Add(companyEmpWage);
        }

        public void ComputeEmpWage()
        {
            foreach (CompanyWage empWage in companyEmpWageList)
            {
                empWage.SetTotalEmpWage(ComputeEmpWage(empWage));
                Console.WriteLine(empWage.ToString());
            }
        }

        private int ComputeEmpWage(CompanyWage companyEmpWage)
        {
            int empHrs = 0, total_Emp_Hrs = 0, totalWorkingDays = 1, daily_Emp_Wage = 0;

            while (totalWorkingDays <= companyEmpWage.working_Days_Per_Month && total_Emp_Hrs <= companyEmpWage.max_Hrs_Per_Month)
            {
                int randomInput = random.Next(0, 3);

                switch (randomInput)
                {
                    case EMP_FULLTIME:
                        empHrs = 8;
                        break;
                    case EMP_PARTTIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                daily_Emp_Wage = empHrs * companyEmpWage.emp_Wage_Per_Hr;
                Console.WriteLine("Employee wage for day {0} is: {1} for {2} Hrs", totalWorkingDays, daily_Emp_Wage, empHrs);
                companyEmpWage.total_Emp_Wage += daily_Emp_Wage;
                total_Emp_Hrs += empHrs;
                totalWorkingDays++;


            }
            Console.WriteLine("Total Days: {0}, Total working hours: {1}", (totalWorkingDays - 1), total_Emp_Hrs);
            Console.WriteLine("Total Employee Wage for company " + companyEmpWage.company + " is: " + companyEmpWage.total_Emp_Wage + "\n");
            return companyEmpWage.total_Emp_Wage;
        }

    }
    //{
    //    private List<CompanyWage> companyEmpWageList;
    //    public const int Is_Full_Time = 1;
    //    public const int Is_Part_Time = 2;
    //    public const int Emp_Rate_Per_Hour = 20;
    //    public const int Num_Working_Days = 20;
    //    public const int Max_Hrs_In_Month = 100;
    //    private string CompanyName;
    //    public const int WorkingDays = 0;
    //    public const int HrsPerMonth = 0;
    //    private int totalEmpWage;



    //    //make random object as static
    //    static Random random = new Random();
    //    public void operation()
    //    {
    //        int empCheck = random.Next(0, 2);
    //        if (empCheck == Is_Full_Time)
    //        {
    //            Console.WriteLine("Employee is present");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Employee is absent");
    //        }
    //    }
    //    //Checking Employee Daily Wage
    //    int EmpHours = 0;
    //    int EmpWage = 0;
    //    public void DailyWage()
    //    {
    //        int empCheck = random.Next(0, 2);
    //        if (empCheck == Is_Full_Time)
    //        {
    //            EmpHours = 8;
    //        }
    //        else
    //        {
    //            EmpHours = 0;
    //        }
    //        EmpWage = EmpHours * Emp_Rate_Per_Hour;
    //        Console.WriteLine("Employee Daily Wage are:" + EmpWage);
    //    }

    //    // Checking Employee is Part Time or not
    //    public void PartTime()
    //    {
    //        int empCheck = random.Next(0, 2);
    //        if (empCheck == Is_Full_Time)
    //        {
    //            EmpHours = 8;
    //        }
    //        else if (empCheck == Is_Part_Time)
    //        {
    //            EmpHours = 4;
    //        }
    //        else
    //        {
    //            EmpHours = 0;
    //        }
    //        EmpWage = EmpHours * Emp_Rate_Per_Hour;
    //        Console.WriteLine("Employee Daily Wage are :" + EmpWage);
    //    }
    //    //Use Switch case statement for Employee Wage
    //    public void IsPartTime()
    //    {
    //        int empCheck = random.Next(0, 2);
    //        switch (empCheck)
    //        {
    //            case Is_Part_Time:
    //                EmpHours = 4;
    //                break;
    //            case Is_Full_Time:
    //                EmpHours = 8;
    //                break;
    //            default:
    //                EmpHours = 0;
    //                break;
    //        }
    //        EmpWage = EmpHours * Emp_Rate_Per_Hour;
    //        Console.WriteLine("Employee Daily Wage using Switch case statement are:" + EmpWage);
    //    }

    //    //Calculating Employee Wage For Month
    //    //creating constant variable i.e Num_Working_Days
    //    public void TotalDays()
    //    {
    //        int EmpHour = 0;
    //        int EmpWage = 0;
    //        int totalEmpWage = 0;

    //        for (int day = 0; day < Num_Working_Days; day++)
    //        {
    //            Random random = new Random();
    //            int empCheck = random.Next(0, 2);
    //            switch (empCheck)
    //            {
    //                case Is_Part_Time:
    //                    EmpHour = 4;
    //                    break;
    //                case Is_Full_Time:
    //                    EmpHour = 8;
    //                    break;
    //                default:
    //                    EmpHour = 0;
    //                    break;
    //            }
    //            EmpWage = EmpHour * Num_Working_Days;
    //            totalEmpWage += EmpWage;
    //        }
    //        Console.WriteLine("Employee wage:" + EmpWage);
    //        Console.WriteLine("Total Employee Wage for month:" + totalEmpWage);
    //    }

    //    //Calculate Wages till condition of total working hours or days is reached for a month
    //    //Assume 100 hours and 20 days
    //    //take constatnt variable MAx_hrs_In_Month=100
    //    public void MonthlyWage()
    //    {
    //        int EmpHours = 0;
    //        int totalWorkingDays = 0;
    //        int totalEmpHrs = 0;
    //        while (totalEmpHrs <= Max_Hrs_In_Month && totalWorkingDays < Num_Working_Days)
    //        {
    //            totalWorkingDays++;
    //            Random random = new Random();
    //            int monthCheck = random.Next(0, 3);
    //            switch (monthCheck)
    //            {
    //                case Is_Part_Time:
    //                    EmpHours = 4;
    //                    break;
    //                case Is_Full_Time:
    //                    EmpHours = 8;
    //                    break;
    //                default:
    //                    EmpHours = 0;
    //                    break;
    //            }
    //            totalEmpHrs += EmpHours;
    //            Console.WriteLine("Days:" + totalWorkingDays + "working hours:" + EmpHours);
    //        }
    //        int totalEmpWage = totalEmpHrs * Emp_Rate_Per_Hour;
    //        Console.WriteLine("Total Employee wage: " + totalEmpWage);
    //    }

    //    //public void CompanyDetails(String CompanyName, int WorkingDays, int HrsPerMonth)
    //    //{
    //    //    Console.WriteLine("Total Days: {0}, Total working hours: {1}", (WorkingDays - 1), HrsPerMonth);
    //    //    Console.WriteLine("Total Employee Wage for company " + CompanyName + " is: " + totalEmpWage + "\n");
    //    //     totalEmpWage = WorkingDays * HrsPerMonth;
    //    //}
    //    //public override string ToString()
    //    //{
    //    //    return "Total Employee Wage for company: " + CompanyName + " is: " + totalEmpWage + "\n";
    //    //}
    //} 

}
