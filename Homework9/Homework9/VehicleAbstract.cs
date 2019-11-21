using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    public abstract class Vehicle
    {
        private string name;
        private int yearofcreation;
        public string regnumber;
        public string engine;

        public string Name { get { return name; } set { this.name = value; } }
        public int YearOfCreation { get { return yearofcreation; } set { this.yearofcreation = value; } }
        public string RegNumber { get { return regnumber; } set { this.regnumber = value; } }
        public string Engine { get { return engine; } set { this.engine = value; } }

        public abstract void Drive(double speed);
        public abstract void GetYears();

        protected Vehicle() { }
        protected Vehicle(string name, int yearofcreation, string regnumber, string engine)
        {
            this.name = name;
            this.yearofcreation = yearofcreation;
            this.regnumber = regnumber;
            this.engine = engine;
        }
    }

    /*public class Car : Vehicle
    {
        private int numberofwheels;
        private bool isturboactivated = false;

        public int NumberOfWheels { get { return numberofwheels; } set { this.numberofwheels = value; } }

        public void StartTurbo()
        {
            
                isturboactivated = true;
                Console.WriteLine("Turbo activated on abstract car. Speed is increased with 30km/h.");
            
        }

        public void StopTurbo()
        {
            
                isturboactivated = false;
                Console.WriteLine("Turbo deactivated.");
            
        }

        public override void Drive(double speed)
        {
            if (this.isturboactivated == true)
            {
                Console.WriteLine("You get 30km/h turbo boost and abstract car is driving at speed of " + (speed + 30) + " km/h");

            }
            else
            {
                Console.WriteLine("Abstract car is driving at speed of " + speed + " km/h");
            }
        }

        public override void GetYears()
        {
            Console.WriteLine("The car is {0} years old", DateTime.Now.Year - this.YearOfCreation);

        }
    }


    public class Motorbike:Vehicle
    {
        public override void Drive(double speed)
        {
            Console.WriteLine("Motorbike is driving at speed of " + speed + " km/h");
        }

        public override void GetYears()
        {
            Console.WriteLine("The car is {0} years old", DateTime.Now.Year - this.YearOfCreation);
        }

    }
    */
}