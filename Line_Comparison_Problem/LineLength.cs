﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparison_Problem
{
    public class LineLength
    {
        int x_One, x_Two, y_One, y_Two;
        public LineLength(int x_One, int x_Two, int y_One, int y_Two)
        {
            this.x_One = x_One;
            this.x_Two = x_Two;
            this.y_One = y_One;
            this.y_Two = y_Two;
        }
        public double Calculate()
        {
            double length = Math.Sqrt(Math.Pow((x_Two - x_One), 2) + Math.Pow((y_Two - y_One), 2));
            Console.WriteLine("Length of line is: " + length);
            return length;
        }
    }
}
