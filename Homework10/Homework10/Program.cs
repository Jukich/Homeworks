using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Homework10
{
    class Program
    {
        public static void Main(string[] args)
        {

            ValueConverter converter = new ValueConverter();
            ValueConverter converter1 = new ValueConverter();

            converter.ValueExceeded += ValueExceededMessage;
            int val1 = 100;
            int val2 = 20500;
            int val3 = 30000;
            Console.WriteLine("{0} euro is equal to {1:0.00} Dollars.\n", val1,converter.ConvertToDolars(val1));
            Console.WriteLine("{0} euro is equal to {1:0.00} Dollars.\n", val2, converter.ConvertToDolars(val2));
            Console.WriteLine("{0} dollars is equal to {1:0.00} euro.\n", val3, converter1.ConvertToEuro(val3));

            Airliner Airbus = new Airliner(800,6000);
            Airbus.HeightReachedHandler += PlaneHeightEvent;
            Airbus.OptimalSpeedReachedHandler += PlaneSpeedReachedEvent;
            Airbus.OptimalSpeedExceedHandler += PlaneSpeedExceededEvent;
            Airbus.LowSpeedHandler += PlaneLowSpeedEvent;
            Airbus.Flight();


            Fighter Boing = new Fighter(1000, 3000,10);
            Boing.HeightReachedHandler += PlaneHeightEvent;
            Boing.OptimalSpeedReachedHandler += PlaneSpeedReachedEvent;
            Boing.RocketThrownHandler += RocketThrownEvent;

            Boing.Flight();
            Console.ReadLine();



            void ValueExceededMessage()
            {
                Console.WriteLine("Converted amount is more than 100000");
            }
            void PlaneHeightEvent()
            {
                Console.WriteLine("Optimal flying hight reached. Switching to autopilot");
            }
            void PlaneSpeedReachedEvent()
            {
                Console.WriteLine("Optimal flying speed reached.");

            }
            void PlaneSpeedExceededEvent()
            {
                Console.WriteLine("Speed is {0}km/h", Airbus.Speed);
                Console.WriteLine("Optimal flying speed exceed.Speed will be decresed by 100km/h.\n");
                Airbus.Speed -= 100;

            }
            void PlaneLowSpeedEvent()
            {
                Console.WriteLine("Speed is {0}km/h", Airbus.Speed);
                Console.WriteLine("Flying speed is too low. Speed will be increased by 100km/h.\n");
                Airbus.Speed += 100;

            }
            void RocketThrownEvent()
            {
                Boing.OptimalSpeed += 100;
                Console.WriteLine("Rocket was thrown. Optimal speed is increased by 100km/h.");
            }

        }
    }
}
