using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 15, 13, 28, 34, 19, 7, 30, 22, 1 };
            int max = int.MinValue;

            for (int i = 0; i < 10; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
