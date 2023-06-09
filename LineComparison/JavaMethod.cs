﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    // UC3- Calculating length of a line using JAVA COMPARETO METHOD.
    internal class JavaMethod
    {
        public void CompareTo()
        {
            Console.Write("Enter the line point x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the line point x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the line point y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the line point y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the line point x3: ");
            int x3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the line point x4: ");
            int x4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the line point y3: ");
            int y3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the line point y4: ");
            int y4 = Convert.ToInt32(Console.ReadLine());

            var Line1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Length of line1 is: " + Line1);

            var Line2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            Console.WriteLine("Length of line2 is:" + Line2);

            // comparing the length of line using JAVA COMPARETO METHOD.
            if (Line1.CompareTo(Line2) > 0)
                Console.WriteLine("Line 1 is greater than Line 2");
            else if (Line2.CompareTo(Line1) > 0)
                Console.WriteLine("Line 2 is greater than Line 1");
            else
                Console.WriteLine("Length are Equals");
        }
    }
}
