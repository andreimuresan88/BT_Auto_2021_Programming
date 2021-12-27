using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    class Sphere
    {
        double radius;
        const double PI = 3.14;

        public Sphere(double radius)
        {
            this.radius = radius;
        }

        public Sphere()
        {
        }

        public double GetVolume()
        {
            return (4 / 3) * PI * Math.Pow(radius, 3);
        }
        
        public double GetVolume(double radius)
        {
            return (4 / 3) * PI * Math.Pow(radius, 3);
        }
    }
}
