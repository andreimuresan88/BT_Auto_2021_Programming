using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    class Cylinder
    {
        double radius;
        double height;
        const double PI = 3.14;

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public Cylinder()
        {
        }

        public double GetVolume(double radius)
        {
            return PI * Math.Pow(radius, 2);
        }

        public double GetVolume()
        {
            return PI * Math.Pow(radius, 2) * height;
        }

        public double GetVolume(double radius, double height)
        {
            return PI * Math.Pow(radius, 2) * height;
        }
    }
}
