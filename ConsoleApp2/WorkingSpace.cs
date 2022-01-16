using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    class WorkingSpace : Room
    {
        public WorkingSpace()
        {
        }

        public WorkingSpace(double roomArea, string[] accessories, double capacity) : base(roomArea, accessories, capacity)
        {
        }
    }
}
