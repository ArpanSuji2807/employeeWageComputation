using System;

namespace employeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            wageComputation monthlyWage = new wageComputation();
            monthlyWage.EmployeeAttendance();
            monthlyWage.MonthlyEmpWage();
        }
    }
}