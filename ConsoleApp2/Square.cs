using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    class Square : Rectangle
    {
        double side;

        public double Side { get => side; set => side = value; }

        public Square()
        {
            
        }

        public Square(double side)
        {
            this.Side = side;
        }

        public void setSide(double side)
        {
            this.Side = side;
        }

        public override double GetArea()
        {
            //return base.GetArea();
            return Math.Pow(Side, 2);
        }

        public void printSquare()
        {
            Console.WriteLine("The square with side {0} has the area {1} ", Side, GetArea());
        }

        public override string ToString()
        {
            return "this is a square with side " + Side;
        }

        public void Draw()
        {
            Console.WriteLine("Drawing a square");
        }
    }


}
