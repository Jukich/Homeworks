using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Library
    {
        private string location;
        private int size;
        private int yearofopening;

        public string Location { get { return location; } set { location = value; } }
        public int Size { get { return size; } set { size = value; } }
        public int YearOfOpening { get { return yearofopening; } set { yearofopening = value; } }

        public  Library( string location, int size, int yearofopening)
        {
            this.location = location;
            this.size = size;
            this.yearofopening = yearofopening;
        }

    }
}
