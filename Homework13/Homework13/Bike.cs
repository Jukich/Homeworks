using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{
    class Bike
    {

        private string brand;
        private string model;
        private string colour;

        public string Brand { get { return brand; } set { this.brand = value; } }
        public string Model { get { return model; } set { this.model = value; } }
        public string Colour { get { return colour; } set { this.colour = value; } }

        public Bike(string brand, string model, string colour)
        {
            this.brand = brand;
            this.model = model;
            this.colour = colour;
        }
    }
}
