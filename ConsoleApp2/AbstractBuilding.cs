using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    abstract class AbstractBuilding : IBuilding
    {
        double IBuilding.ComputingArea()
        {
            throw new NotImplementedException();
        }

        int IBuilding.GetNumberOfFloors()
        {
            throw new NotImplementedException();
        }

        int IBuilding.GetTotalNumberOfRooms()
        {
            throw new NotImplementedException();
        }

        double IBuilding.TotalCapacity()
        {
            throw new NotImplementedException();
        }
    }
}
