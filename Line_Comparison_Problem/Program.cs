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
            LineLength lineLength= new LineLength(2, 3, 4, 5);
            lineLength.Calculate();
            Console.ReadLine();
        }
    }
}
