using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            const int MAX_SIZE = 100;
            const double PI = 3.1415;
            const int MAX_NUMBER = 5;

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

            int[] list = { 1, 3, 4, 6 };
            for (int j = 0; j < list.Length; j++)
            {
                Console.Write(list[j] + " ");
            }

            int number = 53;
            //int number = -100;
            //int number = 0;
            if (number >= 0)
            {
                Console.WriteLine("number is positive");
            }
            else
            {
                Console.WriteLine("number is negative");
            }

            if (number % 2 == 0)
            {
                Console.WriteLine("evan number!");
            }
            else
            {
                Console.WriteLine("odd number");
            }

            if (number <= 40 && number >= 0)
            {
                if (number <= 20)
                {
                    Console.WriteLine("Student failed");
                }
                else
                {
                    Console.WriteLine("student passed");
                }
            }
            else
            {
                Console.WriteLine("number si invalid");
            }
            //one line if/else
            Console.WriteLine((number % 2 == 0 ? "even" : "odd"));

            if (number == 1)
            {
                Console.WriteLine("Monday");
            }
            if (number == 2)
            {
                Console.WriteLine("Tuesday");
            }
            if (number == 3)
            {
                Console.WriteLine("Wedneday");
            }
            if (number == 4)
            {
                Console.WriteLine("Thurday");
            }
            if (number == 5)
            {
                Console.WriteLine("Friday");
            }
            if (number == 6)
            {
                Console.WriteLine("Saturday");
            }
            if (number == 7)
            {
                Console.WriteLine("Sunday");
            }
            if (number > 7 || number < 0)
            {
                Console.WriteLine("invalid number");
            }

            switch (number)
            {
                case 1:
                    {
                        Console.WriteLine("Monday");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Tuesday");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Wedneday");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Thurday");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Friday");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Saturday");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Sunday");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("invalid number");
                        break;
                    }
            }

            int counter = 0;
            while (counter <= MAX_NUMBER)
            {
                Console.WriteLine("Current number is: " + counter);
                Console.WriteLine("Current number is: " + counter.ToString());
                counter++;
            }

            counter = 0;
            do
            {
                Console.WriteLine("Current number is: " + counter);
                counter++;
            } while (counter <= MAX_NUMBER);

            for (counter = 0; counter < MAX_NUMBER; counter++)
            {
                Console.WriteLine("Counter number is: {0}", counter);
            }
        }

    }
}
