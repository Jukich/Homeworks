using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    struct Flower
    {
        private string name;
        private string colour;
        private double height;

        public string Name { get { return this.name; }set { name = value; } }
        public string Colour { get { return this.colour; } set { colour = value; } }
        public double Height { get { return this.height; } set { height = value; } }

        public Flower(string name, string colour, double height)
        {
            this.name = name;
            this.colour = colour;
            this.height = height;
        }

        public static void fl(Flower f)
        {
            Console.WriteLine("Flower " + f.name + " with "+f.colour+" colour and height "+f.height+" blooms");
        }

    }
}
