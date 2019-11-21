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

    class Car : IVehicle
    {
        private int numberofwheels;
        private bool isturboactivated = false;
        
        public string Name { get; set; }
        public int YearOfCreation { get; set; }
        public string RegNumber { get; set; }
        public string Engine { get; set; }
        public int NumberOfWheels { get { return numberofwheels; } set { this.numberofwheels = value; } }


        public void Drive(double speed)
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
        public void GetYears()
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


    class Motorbike:IVehicle
    {

        private int yearofcreation;
        string IVehicle.Name { get; set; }
        int IVehicle.YearOfCreation { get { return this.yearofcreation; } set { this.yearofcreation = value; } }
        string IVehicle.RegNumber { get; set; }
        string IVehicle.Engine { get; set; }

        void IVehicle.Drive(double speed)
        {
             Console.WriteLine("Motorbike is driving at speed of " + speed + " km/h");
           
        }

        void IVehicle.GetYears()
        {
            Console.WriteLine("The motorbike is {0} years old", DateTime.Now.Year - this.yearofcreation);

        }
    }
}
