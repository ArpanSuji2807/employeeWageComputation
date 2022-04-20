using System;
namespace employeeWageComputation;
class Program
{
    static void Main(string[] args)
    { 
       wageComputation airtel= new wageComputation("airtel",20,20,100);
        wageComputation reliance = new wageComputation("reliance",25,20,90);
        airtel.CompaniesWage();
        Console.WriteLine(airtel.ToString());
        reliance.CompaniesWage();
        Console.WriteLine(reliance.ToString());
    }
}
