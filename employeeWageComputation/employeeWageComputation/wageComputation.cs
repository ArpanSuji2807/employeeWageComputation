using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeWageComputation
{
    public class wageComputation
    {
        const int IS_PRESENT = 0;
        public void EmployeeAttendance()
        {
            
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_PRESENT)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
        }
    }
}
