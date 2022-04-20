using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeWageComputation
{
    public class wageComputation
    {
        const int IS_PRESENT = 0, IS_PART_TIME = 1;
        const int IS_FULL_TIME = 2;

        public void EmployeeAttendance()
        {
            
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_PRESENT)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
        }
        public void CompaniesWage(string company, int wage_per_hour, int working_days_per_month, int maximum_working_hours)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs < maximum_working_hours && totalWorkingDays < working_days_per_month)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs += 8;
                        break;
                    case IS_PART_TIME:
                        empHrs += 4;
                        break;
                    default:
                        break;

                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#: " + totalWorkingDays + " EmpHrs: " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * wage_per_hour;
            Console.WriteLine("Total empWage for a month is: " + totalEmpWage);
        }

    }
}
