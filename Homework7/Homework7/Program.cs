using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            //zad1
            Motorbike motorbike1 = new Motorbike("Honda","Black",2005,315,6,2);
            motorbike1.NumberOfGears = 5;
            motorbike1.VehiclePrint();

            Car car1 = new Car("Ford", "Focus","СААААА","Black", 2015, 190,true, 5, 5, 4);
            car1.TopSpeed = 330;
            car1.RegNumber = "CT7777BC";
            car1.NumberOfDoors = 5;
            car1.VehiclePrint();

            Truck truck1 = new Truck("Scania","Blue",2009,160,6,2,8);
            truck1.MoNumberOfSeats = 3;
            truck1.VehiclePrint();

            //zad2
            Person p1 = new Person("Ivan", 25,"ivan@abv.bg");
            Person p2 = new Person("Stoyan", 33, "stoyan@abv.bg");
            Person p3 = new Person("Petar", 41, "petar@abv.bg");
            p1.ShowPerson();
            p2.ShowPerson();
            p3.ShowPerson();


            //zad3
            Phone ph1 = new Phone("Galaxy S10", "Samsung", 1000.50, "Ivan", 3500, 1000000);
            ph1.ShowPhone();

            Console.ReadLine();
        }
    }
}
