using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    class Square : Rectangle
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

        public override double GetArea()
        {
            //return base.GetArea();
            return Math.Pow(side, 2);
        }

        public void printSquare()
        {
            Console.WriteLine("The square with side {0} has the area {1} ", side, GetArea());
        }

        public override string ToString()
        {
            return "this is a square with side " + side;
        }
    }

}
