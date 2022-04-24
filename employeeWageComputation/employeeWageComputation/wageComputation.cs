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
        private int numOfCompanies=0;
        private WageOfCompanies[] wageOfCompaniesArray;

        public wageComputation()
        {
           this.wageOfCompaniesArray = new WageOfCompanies[5];
        }
        public void AddWageOfCompany(string company, int wage_per_hour, int working_days_per_month, int maximum_working_hours)
        {
            wageOfCompaniesArray[this.numOfCompanies] = new WageOfCompanies(company, wage_per_hour, working_days_per_month, maximum_working_hours);
            numOfCompanies++;
        }
        public void CompaniesWage()
        {
            for (int i = 0; i < numOfCompanies; i++)
            {
                wageOfCompaniesArray[i].SetTotalWage(this.CompaniesWage(this.wageOfCompaniesArray[i]));
                Console.WriteLine(this.wageOfCompaniesArray[i].EmpWageOfEachCompany());
            }
        }
        private int CompaniesWage(WageOfCompanies wageOfCompanies)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs < wageOfCompanies.maximum_working_hours && totalWorkingDays < wageOfCompanies.working_days_per_month)
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
            return totalEmpHrs * wageOfCompanies.wage_per_hour;
        }
    }
}
