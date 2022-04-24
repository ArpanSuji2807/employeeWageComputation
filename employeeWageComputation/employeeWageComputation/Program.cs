using System;
namespace employeeWageComputation;
class Program
{
    static void Main(string[] args)
    {
        wageComputation wage = new wageComputation();
        wage.AddWageOfCompany("Tata",20,20,100);
        wage.AddWageOfCompany("Reliance",20,25,90);
        wage.CompaniesWage();
    }
}
