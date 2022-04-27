using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class UC4_EmpWage
    {
        public static void Main(String[] args)
        {
            //Constant
            const int Is_FullTime = 1;
            const int Is_PartTime=2;
            const int EmpWagePerHrs = 20;
            //Variable
            int EmpHrs = 0;
            int EmpWage = 0;

            Random random = new Random();
            int check = random.Next(0, 2);
            switch(check)
            {
                case Is_FullTime:
                    EmpHrs = 8;
                    break;
                case Is_PartTime:
                    EmpHrs = 4;
                    break;
                default:
                    EmpHrs = 0;
                    break;
            }
            EmpWage = EmpHrs * EmpWagePerHrs;
            Console.WriteLine($"Total Emp Wage= {EmpWage}");
        }
    }
}
