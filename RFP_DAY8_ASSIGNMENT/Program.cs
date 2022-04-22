// See https://aka.ms/new-console-template for more information
using RFP_DAY8_ASSIGNMENT;

Console.WriteLine("\nWelcome to SINGLE LINE LENGTH PROGRAM ....................................................................");

int x1, x2, y1, y2;
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
     

