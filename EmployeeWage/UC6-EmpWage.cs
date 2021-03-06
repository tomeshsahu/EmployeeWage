using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class UC6_EmpWage
    {
        public void UC6()
        {
            //Constant
            const int Is_FullTime = 1;
            const int Is_PartTime = 2;
            const int EmpWagePerHrs = 20;
            const int EmpWorkingDays = 20;
            const int EmpMaxWorkingHrs = 100;
            //Variable
            int EmpHrs = 0;
            int EmpWage = 0;
            int totalEmpHrs = 0;
            int Salary = 0;
            for (int i = 1; i <= EmpWorkingDays; i++)
            {
                Random random = new Random();
                int check = random.Next(0, 3);
                switch (check)
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
                Console.WriteLine($"Day{i}= {EmpWage}");
                totalEmpHrs = totalEmpHrs + EmpHrs;
                if(totalEmpHrs<=100)
                {
                    Salary = totalEmpHrs * EmpWagePerHrs;
                }

            }
            Console.WriteLine($"Total Hrs = {totalEmpHrs}");
            Console.WriteLine($"Total Salary= {Salary}"+"\n");
        }
    }
}
