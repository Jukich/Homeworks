using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    class OutOfTimeException:Exception
    {
        public override string Message { get { return "You ran out of time"; } }
        public OutOfTimeException():base()
        { 
        }

        public OutOfTimeException(string message) : base(message)
        {
        }

    }
}
