using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    /*б) "GetYears" - трябва да върне на колко години е колата - това става като от текущата година 
     * се извади годината на производството на автомобила.

Създайте клас Кола, която да имплементира интерфейса. Допълнително да има свойство "Брой гуми" и метод "Старт Турбо".

Създайте клас Мотор, който да имплементира интерфейса. */
    interface IVehicle
    {
      
        string Name { get; set; }
        int YearOfCreation { get; set; }
        string RegNumber { get; set; }
        string Engine { get; set; }

        void Drive(double speed);
        void GetYears();
    }

    class Car : Vehicle, IVehicle
    {
        private int numberofwheels;
        private bool isturboactivated = false;
        
        public int NumberOfWheels { get { return numberofwheels; } set { this.numberofwheels = value; } }

        public Car() { }
        public Car(string name, int yearofcreation, string regnumber, string engine,int numberofwheels)
            :base(name, yearofcreation, regnumber, engine)
        {
            this.numberofwheels = numberofwheels;
        }
        public override void Drive(double speed)
        {
            if (this.isturboactivated == true)
            {
                Console.WriteLine("You get 50km/h turbo boost and car is driving at speed of " + (speed + 50) + " km/h");

            }
            else
            {
                Console.WriteLine("Car is driving at speed of " + speed + " km/h");
            }

        }
        public override void GetYears()
        {
            Console.WriteLine("The car is {0} years old", DateTime.Now.Year - this.YearOfCreation);

        }
        public void StartTurbo()
        {
            this.isturboactivated = true;
            Console.WriteLine("Turbo activated. Speed is increased with 50km/h.");
        }
        public void StopTurbo()
        {
            this.isturboactivated = false;
            Console.WriteLine("Turbo is deactivated");
        }

    }


    class Motorbike:Vehicle,IVehicle
    {

        public Motorbike() { }
        public Motorbike(string name, int yearofcreation, string regnumber, string engine)
            : base(name, yearofcreation, regnumber, engine)
        {
            
        }

        void IVehicle.Drive(double speed)
        {
             Console.WriteLine("Ivehicle motorbike is driving at speed of " + speed + " km/h");
           
        }
        public override void Drive(double speed)
        {
            Console.WriteLine("Abstract motorbike is driving at speed of " + speed + " km/h");

        }


        void IVehicle.GetYears()
        {
            Console.WriteLine("Ivehicle motorbike is {0} years old", DateTime.Now.Year - this.YearOfCreation);

        }
        public override void GetYears()
        {
            Console.WriteLine("Abstract motorbike is {0} years old", DateTime.Now.Year - this.YearOfCreation);

        }
    }
}
