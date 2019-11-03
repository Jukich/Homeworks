using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    public class Vehicle
    {

        private string model;
        private string colour;
        private int yearofcreation;
        private int topspeed;

        public string Model { get { return model; } set { model = value; } }
        public string Colour { get { return colour; } set { colour = value; } }
        public int YearOfCreation { get { return yearofcreation; } set { yearofcreation = value; } }
        public int TopSpeed { get { return topspeed; } set { topspeed = value; } }

        public Vehicle(string model, string colour, int yearofcreation, int topspeed)
        {
            this.model = model;
            this.colour = colour;
            this.yearofcreation = yearofcreation;
            this.topspeed = topspeed;
        }

        public virtual void VehiclePrint()
        {
            Console.WriteLine("Colour: " + colour);
            Console.WriteLine("Year of Creation: " + yearofcreation);
            Console.WriteLine("Top Speed: " + topspeed);
        }

    }

    public class Motorbike : Vehicle
    {

        private const string type = "Motorbike";
        private const int numberofseats = 1;
        private int numberofwheels;
        private int numberofgears;

        public int MoNumberOfWheels { get { return numberofwheels; } set { numberofwheels = value; } }
        public int NumberOfGears { get { return numberofgears; } set { numberofgears = value; } }

        public Motorbike(string model, string colour, int yearofcreation, int topspeed, int numberofgears, int numberofwheels)
            : base(model, colour, yearofcreation, topspeed)
        {

            this.numberofwheels = numberofwheels;
            this.numberofgears = numberofgears;
        }

        public override void VehiclePrint()
        {
            Console.WriteLine("Type of vehicle is: " + type);
            base.VehiclePrint();
            Console.WriteLine("Number of seats: " + numberofseats);
            Console.WriteLine("Number of gears: " + numberofgears);
            Console.WriteLine("Number of wheels: " + numberofwheels + "\n");

        }


    }

    public class Car : Vehicle
    {
        private const string type = "Car";
        private const int numberofwheels = 4;
        private string brand;
        private string regnumber;
        private bool isDiesel;
        private int numberofseats;
        private int numberofgears;
        private int numberofdoors;


        public string Brand { get { return brand; } set { brand = value; } }
        public string RegNumber { get { return regnumber; } set { regnumber = value; } }
        public bool IsDiesel { get { return isDiesel; } set { isDiesel = value; } }
        public int MoNumberOfSeats { get { return numberofseats; } set { numberofseats = value; } }
        public int NumberOfGears { get { return numberofgears; } set { numberofgears = value; } }
        public int NumberOfDoors { get { return numberofdoors; } set { numberofdoors = value; } }


        public Car(string model, string brand, string regnumber, string colour, int yearofcreation, int topspeed,  bool isDiesel,
            int numberofgears, int numberofseats, int numberofdoors)
            : base(model, colour, yearofcreation, topspeed)
        {
            this.brand = brand;
            this.regnumber = regnumber;
            this.isDiesel = isDiesel;
            this.numberofseats = numberofseats;
            this.numberofgears = numberofgears;
            this.numberofdoors = numberofdoors;

        }

        public override void VehiclePrint()
        {
            Console.WriteLine("Type of vehicle is: " + type);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Brand: " + brand);
            Console.WriteLine("Registration number: " + regnumber);
            Console.WriteLine($"Is Diesel: {(isDiesel ? "Yes" : "No")}");


            base.VehiclePrint();
            Console.WriteLine("Number of seats: " + numberofseats);
            Console.WriteLine("Number of gears: " + numberofgears);
            Console.WriteLine("Number of wheels: " + numberofwheels);
            Console.WriteLine("Number of doors: " + numberofdoors + "\n");
        }

    }

    public class Truck : Vehicle
    {

        private const string type = "Truck";
        private const int numberofdoors = 2;
        private int numberofwheels;
        private int numberofseats;
        private int numberofgears;

        public int MoNumberOfSeats { get { return numberofseats; } set { numberofseats = value; } }
        public int NumberOfGears { get { return numberofgears; } set { numberofgears = value; } }
        public int NumberOfDoors { get { return numberofdoors; } set { numberofwheels = value; } }

        public Truck(string model, string colour, int yearofcreation, int topspeed, int numberofgears, int numberofseats,
            int numberofwheels)
            : base(model, colour, yearofcreation, topspeed)
        {
            this.numberofseats = numberofseats;
            this.numberofgears = numberofgears;
            this.numberofwheels = numberofwheels;
        }

        public override void VehiclePrint()
        {
            Console.WriteLine("Type of vehicle is: " + type);
            base.VehiclePrint();
            Console.WriteLine("Number of seats: " + numberofseats);
            Console.WriteLine("Number of gears: " + numberofgears);
            Console.WriteLine("Number of wheels: " + numberofwheels);
            Console.WriteLine("Number of doors: " + numberofdoors + "\n");
        }


    }
}
