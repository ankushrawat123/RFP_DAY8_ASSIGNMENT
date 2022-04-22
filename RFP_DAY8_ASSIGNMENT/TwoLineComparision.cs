using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_DAY8_ASSIGNMENT
{
    internal class TwoLineComparision
    {
        public void TwoLineLength(int x1,int x2,int x3, int x4, int y1, int y2, int y3, int y4)
        {

            double length1 = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            double length2 = Math.Sqrt(Math.Pow((x3 - x4), 2) + Math.Pow((y3 - y4), 2));

            double z = length1.CompareTo(length2);

            if ( z > 1)
            {
                Console.WriteLine("line 1 of length {0} units is greater than Line 2 of length {1} units ", length1, length2);
            }
            else if (z < 1)
            {
                Console.WriteLine("line 1 of length {0} units is less than Line 2 of length {1} units ", length1, length2);
            }
           else
            {
                Console.WriteLine("line 1 of length {0} units is equal to Line 2 of length {1} units", length1, length2);
            }
           
            Console.WriteLine("Length of line1 is : {0} units ", length1);
            Console.WriteLine("Length of line2 is : {0} units ", length2);


           
        }
    }
}
