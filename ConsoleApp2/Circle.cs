﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    class Circle
    {
        double radius;
        //const double PI = 3.1415;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public Circle()
        {
            this.radius = 0;
        }

        public void setRadius(double radius)
        {
            this.radius = radius;
        }

        public double getArea()
        {
            return Math.PI * Math.Pow(radius,2);  
        }
        public void PrintCircle()
        {
            Console.WriteLine("Circle with radius {0} has the area {1} ", radius, getArea());
        }
    }
}
