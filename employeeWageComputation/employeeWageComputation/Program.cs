using System;

namespace employeeWageComputation;

class Program
{
    static void Main(string[] args)
    { 
       wageComputation wage= new wageComputation();
        Console.WriteLine("Company name: ");
        string company = Console.ReadLine();
        Console.WriteLine("Rate per hour: ");
        int wage_per_hour = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Monthly Working Days: ");
        int working_days_per_month = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Maximum working hours: ");
        int maximum_working_hours = Convert.ToInt32(Console.ReadLine());
        wage.CompaniesWage(company, wage_per_hour, working_days_per_month, maximum_working_hours);
    }
}
