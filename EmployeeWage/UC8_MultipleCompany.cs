using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class MultiPleCompany
    {
        //Constant
        public const int FullTime = 1;
        public const int PartTime = 2;
        //Variable
       public string Companyname;
       public int EmpRatePerHrs;
       public int MonthlyMaxPerHrs;
       public int WorkingDay;
        
        
        public MultiPleCompany(string companyName,int EmpRatePerHrs,int MonthlyMaxPerHrs, int WorkingDay)
        {
            this.Companyname = companyName;
            this.EmpRatePerHrs= EmpRatePerHrs;
            this.MonthlyMaxPerHrs= MonthlyMaxPerHrs;
            this.WorkingDay = WorkingDay;
        }
        public void MCompany()
        {
            int empHrs = 0;
            int totalHrs = 0;
            int salary = 0;
            int totalSalary = 0;

            Console.WriteLine($"Company Name {Companyname}"+"\n");
            for (int i=1;i<=20;i++)
            {
                Random rand = new Random();
                int option = rand.Next(0, 3);
                switch(option)
                {
                    case FullTime:
                        empHrs = 8;
                        break;

                    case PartTime:
                        empHrs = 4;
                        break;

                     default:
                        empHrs = 0;
                        break;
                }

                salary = empHrs * EmpRatePerHrs;
                
                Console.WriteLine($"Day{i} = {salary}");
                if (empHrs < 100)
                {
                    totalHrs += empHrs;
                }

            }
            totalSalary = totalHrs * EmpRatePerHrs;
            Console.WriteLine("Total Hrs= " + totalHrs);
            Console.WriteLine("Total Salary= "+totalSalary);
            
        }
    }

    public class UC8_MultipleCompany
    {
        public static void Main(String[] args)
        {
            MultiPleCompany uc8 = new MultiPleCompany("xamptech", 20, 100, 20);
            MultiPleCompany uc81 = new MultiPleCompany("DMart", 18, 80, 25);
            uc8.MCompany();
            uc81.MCompany();
        }
    }
}
