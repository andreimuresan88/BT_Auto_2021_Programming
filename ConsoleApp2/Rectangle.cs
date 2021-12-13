﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    class Rectangle
    {
        double length;
        double width;

        public void SetSize(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double GetArea()
        {
            return length * width;
        }

        public void PrintRectangle()
        {
            Console.WriteLine("The rectangle with length {0} asn width {1} has area {2}", length, width, GetArea());
        }

    }
}
