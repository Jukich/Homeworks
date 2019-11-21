using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    class ValueConverter
    {
        public delegate void ValueSizeHandler();
        public event ValueSizeHandler ValueExceeded;

   

        public double ConvertToDolars(int value)
        {
            
            if (value>10000)
            {
                if (ValueExceeded != null)
                     ValueExceeded.Invoke();
                return value * 1.108198;

            }
            return value * 1.108198;
        }

   

        public  double ConvertToEuro(int value)
        {
            if (value > 10000)
            {
                if(ValueExceeded!=null)
                    ValueExceeded.Invoke();
                return value * 0.902366;
            }
            return value * 0.902366;
        }


    }
}
