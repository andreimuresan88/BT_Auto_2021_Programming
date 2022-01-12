using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    interface IBuilding
    {
        public double ComputingArea();
        public int GetNumberOfFloors();
        public int GetTotalNumberOfRooms();
        public double TotalCapacity();
    }
}
