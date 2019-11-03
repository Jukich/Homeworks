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
            Console.WriteLine("Task 1");
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
            Console.WriteLine("Task 2");
            Person[] persons = new Person[10];
            persons[0] = new Person("Ivan",9701017676, 25,"ivan@abv.bg");
            persons[1] = new Person("Stoyan", 9702027676, 33, "stoyan@abv.bg");
            persons[2] = new Person("Petar",  9703037676, 41, "petar@abv.bg");
            persons[3] = new Person("Georgi",  9704047676, 41, "Georgi@abv.bg");
            persons[4] = new Person("Vasil",  9705057676, 41, "Vasil@abv.bg");
            persons[5] = new Person("Stanislav",  9706067676, 41, "Stanislav@abv.bg");
            persons[6] = new Person("Stilyan",  9707077676, 41, "Stilyan@abv.bg");
            persons[7] = new Person("Todor",  9708087676, 41, "Todor@abv.bg");
            persons[8] = new Person("Milen",  9790907676,41, "Milen@abv.bg");
            persons[9] = new Person("Atanas", 9710107676,41, "Atanas@abv.bg");

            foreach (Person p in persons)
            {
                Console.WriteLine(p.Name + " Egn: " + p.Egn);
            }


            //zad3
            Console.WriteLine("\nTask 3");
            Phone ph1 = new Phone("Galaxy S10", "Samsung", 1000.50, "Ivan", 3500, 1000000);
            ph1.ShowPhone();


            //zad4
            Console.WriteLine("\nTask 4");
            Flower rose = new Flower("Rose", "Red", 50.15);
            Flower.fl(rose);
            //Console.WriteLine("\nFlower is: "+ rose.Name +"Colour is: " + rose.Colour +"Height is :"+ rose.Height+"\n");


            //zad5
            Console.WriteLine("\nTask 5");
            Console.WriteLine(ConvertDegree.ConvertToFarenheit(30));
            Console.WriteLine(ConvertDegree.ConvertToCelsius(86));


            //zad6
            Console.WriteLine("\nTask 6");
            Library lib1 = new Library("Sofia", 500, 2009);
            Console.WriteLine("Library is located in " + lib1.Location + ", it contains " + lib1.Size
                + " books and its year of opening is " + lib1.YearOfOpening);

            //zad7
            Console.WriteLine("\nTask 7");
            Book book1 = new Book("Hamlet", "William Shakespeare", 1600, 300);
            Console.WriteLine("Book title is " + book1.Title + ", it's author is " + book1.Author 
                + " books, its year of creation is " + book1.YearOfCreation + " and has 300 pages" );
            Book.PrintPage(book1,5);


            //Queue 
            Console.WriteLine("\nQueue Example");

            QueueCustom q = new QueueCustom();
            int index = 1;

            Console.WriteLine("Enqueue " + q.Enqueue(1));
            Console.WriteLine("Enqueue " + q.Enqueue(2));
            Console.WriteLine("Enqueue " + q.Enqueue(3));
            Console.WriteLine("Enqueue " + q.Enqueue(4));
            Console.WriteLine("Enqueue " + q.Enqueue(5));

            Console.WriteLine("Dequeue " + q.Dequeue());
            Console.WriteLine("Dequeue " + q.Dequeue());
            Console.WriteLine("Dequeue " + q.Dequeue());
            Console.WriteLine("Enqueue " + q.Enqueue(5));

            Console.WriteLine("Dequeue " + q.Dequeue());
            Console.WriteLine("Dequeue " + q.Dequeue());

            Console.WriteLine("Enqueue " + q.Enqueue(6));

           // q.Clear();
            Console.WriteLine("Enqueue " + q.Enqueue(15));

            Console.WriteLine("Element at index " +index +": "+ q.ElementAt(index));

            Console.WriteLine("Queue size " + q.Size);
            Console.WriteLine("Queue contains this element: " + q.Contains(6));

            Console.ReadLine();

        }
    }
}
