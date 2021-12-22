using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    class Author
    {
        string name;
        string email;

       public Author(string name, string email)
        {
            this.name = name;
            this.email = email;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetEmail()
        {
            return email;
        } 

        public void SetEmail(string email)
        {
            this.email = email;
        }
    }
}
