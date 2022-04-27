
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    public class UC1_EmplyeeWage
    {
        const int Is_FullTime = 1;
        public static void Main(String[] args)
        {
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == Is_FullTime)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

        }
    }
}
