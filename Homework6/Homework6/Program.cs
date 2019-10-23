using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class Program
    {
        static void Person(string name, int age)
        {
            Console.WriteLine(name);
            Console.WriteLine(age + "\n");

        }

        static bool numbers(int[] arr, int p)
        {
            bool b = false;
            foreach (int i in arr)
            {
                if (i == p)
                {
                    b = true;
                }
            }
            return b;

        }

        static bool IsEqual(int a, int b)
        {
            if (a == b)
            {
                return true;
            }
            else
                return false;
        }

        static ulong sum(ulong p)
        {
            if (p == 0)
            {
                return p;
            }
            return p + sum(p - 1);
        }

        static void Main(string[] args)
        {

            //Task1
            Person("Ivan", 20);
            Person("Stoyan", 30);
            Person("Petar", 40);
            Person("Kaloyan", 33);

            //Task2
            int[] arr = { 1, 2, 3, 4, 5 };
            int n = 6;
            Console.WriteLine(numbers(arr, n));

            //Task3
            Console.WriteLine(IsEqual(2, 2));

            //Task4
            Console.WriteLine(sum(5));
           

            Console.ReadLine();


        }
    }
}
