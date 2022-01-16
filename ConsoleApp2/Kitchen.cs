using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    class Kitchen : Room
    {
        public Kitchen()
        {
        }

        public Kitchen(double roomArea, string[] accessories, double capacity) : base(roomArea, accessories, capacity)
        {
        }
    }
}
