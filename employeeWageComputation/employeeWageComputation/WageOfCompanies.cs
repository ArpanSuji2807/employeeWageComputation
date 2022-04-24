using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeWageComputation
{
    public class WageOfCompanies
    {
        private string company;
        public int wage_per_hour, working_days_per_month, maximum_working_hours;
        private int totalEmpwage;
        public WageOfCompanies(string company, int wage_per_hour, int working_days_per_month, int maximum_working_hours)
        {
            this.company = company;
            this.wage_per_hour = wage_per_hour;
            this.working_days_per_month = working_days_per_month;
            this.maximum_working_hours = maximum_working_hours;
        }

        public void SetTotalWage(int totalEmpwage)
        {
            this.totalEmpwage=totalEmpwage;
        }
        public string EmpWageOfEachCompany()
        {
            return "Total employee wage for " + this.company + " company is: " + totalEmpwage;
        }
    }
}
