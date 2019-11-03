using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class ConvertDegree
    {
 
        public static double ConvertToFarenheit(double celsius)
        {
            Console.Write(celsius + " degrees in farenheit:");
            return celsius * 9 / 5 + 32;
        }
        public static double ConvertToCelsius(double farenheit)
        {
            Console.Write(farenheit + " degrees in celsius: ");

            return (farenheit - 32) * 5 / 9;
        }
    }
}
