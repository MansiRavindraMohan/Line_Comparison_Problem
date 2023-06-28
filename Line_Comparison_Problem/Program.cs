using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparison_Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            LineLength obj_One = new LineLength(2, 3, 4, 5);
            double length_One = obj_One.Calculate();
            LineLength obj_Two = new LineLength(2, 3, 4, 5);
            double length_Two = obj_Two.Calculate();
            if (length_One.Equals(length_Two))
            {
                Console.WriteLine("Length of both lines are equal");
            }
            else
            {
                Console.WriteLine("Length of both lines are not equal");
            }
            Console.ReadLine();
        }
    }
}
