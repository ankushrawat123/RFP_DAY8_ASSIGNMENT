// See https://aka.ms/new-console-template for more information
using RFP_DAY8_ASSIGNMENT;


int Option,x1, x2,x3,x4, y1, y2,y3,y4;
Console.WriteLine("Enter \n 1 for ONE LINE LENGTH PROGRAM \n2 for TWO LINE COMPARISION PROGRAM ");
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


}


     

