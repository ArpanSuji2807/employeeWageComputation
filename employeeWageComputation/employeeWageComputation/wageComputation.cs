using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeWageComputation
{
    public class wageComputation
    {
        const int IS_PART_TIME = 1;
        const int IS_FULL_TIME = 2;
        private string company;
        private int wage_per_hour, working_days_per_month, maximum_working_hours;
        private int totalEmpwage;

        public wageComputation(string company, int wage_per_hour, int working_days_per_month, int maximum_working_hours)
        {
            this.company = company;
            this.wage_per_hour = wage_per_hour;
            this.working_days_per_month = working_days_per_month;
            this.maximum_working_hours = maximum_working_hours;
        }
        public void CompaniesWage()
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
        public string EmpWageOfEachCompany()
        {
            return "Total employee wage for each company is: " + this.company + "is: " + totalEmpwage;
        }
        
    }
}
