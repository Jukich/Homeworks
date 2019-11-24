using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    class EqualNumbersException : Exception
    {
        private string message = "Number is negative";
        public override string Message { get { return message; } }
        public EqualNumbersException() : base() { }
        public EqualNumbersException(string message) : base(message)
        {
            this.message = message;
        }

    }
    class NegativeNumberException : Exception
    {
        private string message = "Number is negative";
        public override string Message { get { return message; }}
        public NegativeNumberException() : base() { }
        public NegativeNumberException(string message) : base(message)
        {
            this.message = message;
        }

    }
}
