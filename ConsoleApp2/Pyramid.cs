using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    class Pyramid
    {
        double length;
        double width;
        double height;

        public Pyramid(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public Pyramid()
        {
        }

        public double GetVolume()
        {
            return (length * width * height) / 3;
        }
        
        public double GetVolume(double length, double width, double height)
        {
            return (length * width * height) / 3;
        }
    }
}
