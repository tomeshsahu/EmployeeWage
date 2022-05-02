
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmloyeeWage
{
    public class UC1_EmpWage
    {
        public void UC1()
        {
            const int Is_FullTime = 1;

            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == Is_FullTime)
            {
                Console.WriteLine("Employee is Present" + "\n");
            }
            else
            {
                Console.WriteLine("Employee is Absent"+"\n");
            }
        }
    }
}
