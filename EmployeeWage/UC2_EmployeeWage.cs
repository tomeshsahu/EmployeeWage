using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class UC2_EmployeeWage
    {
        public static void Main(String[] args)
        {
            //Constant
            const int Is_FullTime = 1;
            const int EmpWagePerHrs = 20;
            //Variable
            int EmpHrs=0;
            int EmpWage=0;

            Random random = new Random();
            int check = random.Next(0, 2);
            if(check==Is_FullTime)
            {
                EmpHrs= 8;
            }
            else
            {
                Console.WriteLine("Employee Is Absent");
            }
            Console.WriteLine($"Employee Wage= { EmpHrs * EmpWagePerHrs}");
        }
    }
}
