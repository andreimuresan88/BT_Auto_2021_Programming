using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    class Square
    {
        double side;

        public Square()
        {

        }

        public Square(double side)
        {
            this.side = side;
        }

        public void setSide(double side)
        {
            this.side = side;
        }

        public double getArea()
        {
            return Math.Pow(side, 2);
        }

        public void printSquare()
        {
            Console.WriteLine("The square with side {0} has the area {1} ", side, getArea());
        }
    }

}
