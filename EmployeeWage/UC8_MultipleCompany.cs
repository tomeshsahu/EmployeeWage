using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class UC8_EmpWage
    {
        //Constant
        public const int FullTime = 1;
        public const int PartTime = 2;
        //Variable
       public string Companyname;
       public int EmpRatePerHrs;
       public int MonthlyMaxPerHrs;
       public int WorkingDay;
        
        
        public UC8_EmpWage(string companyName,int EmpRatePerHrs,int MonthlyMaxPerHrs, int WorkingDay)
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
            Console.WriteLine("Total Salary= "+totalSalary+"\n");
            
        }
    }

   
}
