using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class UC3_EmpWage
    {
        public void UC3()
        {
            //Constant
            const int Is_FullTime = 1;
            const int Is_PartTime = 2;
            const int EmpWagePerHrs = 20;
            //Variable
            int EmpHrs = 0;
            int EmpWage = 0;

            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == Is_FullTime)
            {
                EmpHrs = 8;
            }
            else if (check == Is_PartTime)
            {
                EmpHrs = 4;
            }
            else
            {
                EmpHrs = 0;
            }
            Console.WriteLine($"Employee Wage= { EmpHrs * EmpWagePerHrs}"+"\n");
        }
    }
}
