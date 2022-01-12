using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    class BuildingException : Exception
    {
        string myCustomeMessage;
        public BuildingException(string message)
        {
            this.myCustomeMessage = "Building EXCEPTION " + message;
        }

        public BuildingException() : base("Building EXCEPTION")
        {

        }

        public override string ToString()
        {
            return myCustomeMessage + base.ToString();
        }
    }
}
