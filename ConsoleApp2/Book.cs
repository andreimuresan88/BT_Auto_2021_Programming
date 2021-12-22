using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    class Book
    {
        string name;
        int year;
        Author author;
        double price;

        public Book(string name, int year, Author author, double price)
        {
            this.name = name;
            this.year = year;
            this.author = author;
            this.price = price;
        }

        public string GetName()
        {
            return name;
        }

        public int GetYear()
        {
            return year;
        }

        public Author GetAuthor()
        {
            return author;
        }

        public double GetPrice()
        {
            return price;
        }
    }
}
