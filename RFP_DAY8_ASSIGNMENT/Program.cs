// See https://aka.ms/new-console-template for more information
using RFP_DAY8_ASSIGNMENT;

int Is_Full_Time = 1;
int Is_Part_Time = 2;
int Emp_Rate_Per_Hour = 20;

int Option,x1, x2,x3,x4, y1, y2,y3,y4;
Console.WriteLine("Enter \n 1 for ONE LINE LENGTH PROGRAM \n2 for TWO LINE COMPARISION PROGRAM \n3 for ATTENDANCE PROGRAM \n4 for WAGE PROGRAM \n5 for PART PROGRAM \n6 for SWITCH_WAGE PROGRAM \n7 for Working_20_Days PROGRAM ");
Option = Convert.ToInt32(Console.ReadLine());
switch (Option)
{
    case 1:
        Console.WriteLine("\nWelcome to SINGLE LINE LENGTH PROGRAM ....................................................................");


        Console.WriteLine("Enter the coordinates value for points ");
        Console.WriteLine("Enter coordinate x for point1");
        x1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter coordinate y for point1");
        y1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter coordinate x for point2");
        x2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter coordinate y for point2");
        y2 = Convert.ToInt32(Console.ReadLine());

        LineLength obj1 = new LineLength();
        obj1.lineLengthMethod(x1, x2, y1, y2);

        break;

    case 2:
        Console.WriteLine(" \n Welcome to PERFECT NUMBER Program .............................................");


        Console.WriteLine("Enter the coordinates value for points ");
        Console.WriteLine("Enter coordinate x for point1 of Line1");
        x1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter coordinate y for point1 of Line1");
        y1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter coordinate x for point2 of Line1");
        x2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter coordinate y for point2 of Line1");
        y2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter coordinate x for point1 of Line2");
        x3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter coordinate y for point1 of Line2");
        y3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter coordinate x for point2 of Line2");
        x4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter coordinate y for point2 of Line2");
        y4 = Convert.ToInt32(Console.ReadLine());
        TwoLineComparision obj2 = new TwoLineComparision();
        obj2.TwoLineLength(x1,x2,x3,x4,y1,y2,y3,y4);
        break;

    case 3:
        Console.WriteLine(" \n Welcome to Employee Attendance Program .............................................");
        Random obj = new Random();
        int num = obj.Next(0, 2);
        Attendance obj3 = new Attendance();
        obj3.attendanceMethod(Is_Full_Time, num);
        break;

    case 4:
        WageUc obj4 = new WageUc();
        obj4.Wage(Is_Full_Time, Emp_Rate_Per_Hour); 
        break;

    case 5:
        ParttimeUc obj5 = new ParttimeUc();
        obj5.Wage(Is_Full_Time, Is_Part_Time, Emp_Rate_Per_Hour);
        break;

    case 6:
        SwitchWageUc obj6 = new SwitchWageUc();
        obj6.EmpWage();
        break;

    case 7:
        Working20DaysUc obj7 = new Working20DaysUc();
        obj7.Emp20DaysWage();
        break;
}


     

