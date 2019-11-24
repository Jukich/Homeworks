using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    class Program
    {
        static void Main(string[] args)
        {
            GameForSpeed.Game(5);
            int a = 3;
            int b = 3;
            try
            {
                Console.WriteLine(addition(a, b));
            }
            catch(EqualNumbersException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (NegativeNumberException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static double addition(int a, int b)
        {
            if (a == b)
                throw new EqualNumbersException();
            if (a < 0 || b < 0)
                throw new NegativeNumberException();
            return a + b;
        }
    }
}
