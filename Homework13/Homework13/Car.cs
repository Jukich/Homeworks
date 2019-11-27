using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{
    class Car
    {
        private string brand;
        private string model;
        private string regnumber;
        private int seatsnumber;

        public string Brand { get { return brand; } set { this.brand = value; } }
        public string Model { get { return model; } set { this.model = value; } }
        public string RegNumber { get { return regnumber; } set { this.regnumber = value; } }
        public int SeatsNumber { get { return seatsnumber; } set { this.seatsnumber = value; } }

        public Car(string brand, string model, string regnumber, int seatsnumber)
        {
            this.brand = brand;
            this.model = model;
            this.regnumber = regnumber;
            this.seatsnumber = seatsnumber;

        }

    }
}
