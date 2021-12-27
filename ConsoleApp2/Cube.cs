using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    class Cube
    {
        double side;

        public Cube(double side)
        {
            this.side = side;
        }

        public Cube()
        {
        }

        public double GetVolume()
        {
            return Math.Pow(side, 3);
        }

        public double GetVolume(double side)
        {
            return side * side * side;
        }

    }
}
