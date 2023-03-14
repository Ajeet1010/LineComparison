using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    // UC1- Calculating length of a Cartesian line.
    internal class Length
    {
        public void Compare()
        {
            Console.Write("Enter the line point x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the line point x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the line point y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the line point y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            var Length = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            Console.WriteLine("Length is:  " + Length);
        }
    }
}
