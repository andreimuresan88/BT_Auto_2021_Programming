using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    class BTException : Exception
    {
        string myCustomeMessage;
        public BTException (string message)
        {
            this.myCustomeMessage = "BT EXCEPTION " + message;
        }

        public BTException() : base("BT EXCEPTION")
        {
      
        }

        public override string ToString()
        {
            return myCustomeMessage + base.ToString();
        }
    }
}
