using System;

namespace employeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            wageComputation computation = new wageComputation();
            computation.EmployeeAttendance();
            wageComputation DailyWage = new wageComputation();
            DailyWage.DailyEmpWage();
            wageComputation PartTime = new wageComputation();
            PartTime.DailyEmpWage();
            wageComputation SwitchCase = new wageComputation();
            SwitchCase.DailyEmpWage();
            wageComputation MonthlyWage = new wageComputation();
            MonthlyWage.DailyEmpWage();
            wageComputation MonthlyWage1 = new wageComputation();
            MonthlyWage1.DailyEmpWage();
        }
    }
}