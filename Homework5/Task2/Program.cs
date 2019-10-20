using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Lorem ipsum dolor sit amet, consectetur adipiscing elit";
            string[] SplittedString;
            int i = 0;
            char[] c = { ',', '\t', ' ' };

            SplittedString = str.Split(c, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Words in string:");

            foreach (string s in SplittedString)
            {
                Console.WriteLine(i + 1 + "." + SplittedString[i]);
                i++;
            }
            Console.ReadLine();
        }
    }
}
