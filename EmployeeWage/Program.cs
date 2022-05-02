using System;
using EmloyeeWage;
using EmployeeWage;

Console.WriteLine("Welcome to Employee Wage Problem");
bool check = true;
while (check)
{

    Console.WriteLine("1.UC1_Employee Attendance\n2.UC2_Employee FullTime\n3.UC3_Employee PartTime\n4.UC4_Emp Wage Switch Case\n5.UC5_EmpWage Working Days\n6.UC6_EmpWage Max Hrs\n7.UC7_EmpWage Refactor\n8.UC8_EmpWage MultipleCompany\n9.UC9_EmpWageCompany");
    Console.WriteLine("Please Enter the Number Which program you want to run");
    int option = Convert.ToInt32(Console.ReadLine());

    switch(option)
    {
        case 1:
            UC1_EmpWage Obj = new UC1_EmpWage();
            Obj.UC1();
            break;

            case 2:
            UC2_EmployeeWage obj2 = new UC2_EmployeeWage();
            obj2.UC2();
            break;

        case 3:
            UC3_EmpWage obj3 = new UC3_EmpWage();
            obj3.UC3();
            break;

        case 4:
            UC4_EmpWage obj4 = new UC4_EmpWage();
            obj4.UC4();
            break;

        case 5:
            UC5_EmpWage obj5 = new UC5_EmpWage();
            obj5.UC5();
            break;

        case 6:
            UC6_EmpWage obj6 = new UC6_EmpWage();
            obj6.UC6();
            break;

        case 7:
            UC7_EmpWage obj7 = new UC7_EmpWage();
            obj7.UC7();
            break;

        case 8:
            UC8_EmpWage obj8 = new UC8_EmpWage("Xamptech",20,100,20);
            UC8_EmpWage obj88 = new UC8_EmpWage("DMart", 25, 80, 25);
            obj8.MCompany();
            obj88.MCompany();
            break;

        case 9:
            UC9_EmpWageCompany obj9 = new UC9_EmpWageCompany("DMart", 20, 90, 20);
            UC8_EmpWage obj99 = new UC8_EmpWage("Relance", 25, 80, 25);
            obj9.MCompany();
            obj99.MCompany();
            break;

        case 0:
            check = false;
            break;
        default:
            Console.WriteLine("Please Enter Valid Number");
            break;

    }
}