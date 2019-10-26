using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    /*модел, производител, цена, собственик, характеристики на батерията и характеристики на екрана (големина и цветове).
*/
    class Phone
    {
        string model;
        string manufacturer;
        double price;
        string owner;
        int batteryCapacity;
        int screenColours;

        public string Model { get { return model; } set { model = value; } }
        public string Manufacturer { get { return manufacturer; } set { manufacturer = value; } }
        public double Price { get { return price; } set { price = value; } }
        public string Owner { get { return owner; } set { owner = value; } }
        public int BatteryCapacity { get { return batteryCapacity; } set { batteryCapacity = value; } }
        public int ScreenColours { get { return screenColours; } set { screenColours = value; } }

        public Phone(string model, string manufacturer,  double price, string owner, int batteryCapacity, int screenColours)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.batteryCapacity = batteryCapacity;
            this.screenColours = screenColours;
        }

        public void ShowPhone()
        {
            Console.WriteLine("\nModel:{0}\nManufacturer:{1}\nPrice:{2}$\nOwner:{3}\nBaterry Capacity:{4}mAh\n" +
                "Number of screen colours: {5}",model,manufacturer,price,owner,batteryCapacity,screenColours);
        }

    }
}
