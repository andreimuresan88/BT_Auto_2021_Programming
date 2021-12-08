using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            const int MAX_SIZE = 100;
            const double PI = 3.1415;

            Console.WriteLine("Hello World!");

            int numberOfStudents = 5;
            int count;
            count = 7;
            int a, b;
            a = numberOfStudents + 1;
            a = a + numberOfStudents;

            float numerFloat = 5.6f;
            float numerFloat2 = (float)5.6;
            double numerDouble = 5.6;

            float f = (float)numerDouble;
            int numberInt = (int)f;
            long i = numberOfStudents;

            bool myBoolean = false;

            char ch = 'a';

            string myString = "Ana are mere si pere";
            string result = myString + "si struguri";
            Console.WriteLine(result);

            DateTime dataCurenta = new DateTime(2021, 12, 8);

            Console.WriteLine(dataCurenta);

            Console.WriteLine(numerDouble * a);
            Console.WriteLine(numerFloat * a);
            Console.WriteLine(numerFloat / a);
            Console.WriteLine(numerDouble / a);
            Console.WriteLine(5 / 6);
            Console.WriteLine(5 / 6f);
            Console.WriteLine(5 / 6.0);
            Console.WriteLine(5 % 6);

            int x = 2;
            x = x + 5;
            x += 5;

            Console.WriteLine((x == a));
            Console.WriteLine((x < a));
            Console.WriteLine((x > a));
            Console.WriteLine((x != a));


            Console.WriteLine(typeof(int).IsPrimitive);
            Console.WriteLine("Hello World!");
        }
    }
}
