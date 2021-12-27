using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    class Torus
    {
        double minorRadius;
        double majorRadius;
        const double PI = 3.14;

        public Torus(double minorRadius, double majorRadius)
        {
            this.minorRadius = minorRadius;
            this.majorRadius = majorRadius;
        }

        public Torus()
        {
        }

        public double GetVolume()
        {
            return (PI * Math.Pow(minorRadius, 2)) * (2 * PI * majorRadius);
        }
        public double GetVolume(double minorRadius, double majorRadius)
        {
            return (PI * Math.Pow(minorRadius, 2)) * (2 * PI * majorRadius);
        }
    }
}
