using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Homework10
{/*Направете базов клас – самолет и два класа наследници – боен и пътнически. 
    Нека самолетите всеки самолет да има две полета – текуща скорост и текуща височина. 
    Пътническият има още брой пътници, докато бойният има брой ракети. Създайте две  събития
    – едното да се „задейства“ при в достигане на определена височина, другото при достигане на определена скорост. 
    \Може ли да направите различните самолети задействат събитията при различни скорост и височина?
    Ако да – направете го8*/

    abstract class Plane :IFlight
    {
        public delegate void HeightReached();
        public abstract event HeightReached HeightReachedHandler;

        public delegate void SpeedControl();
        public abstract event SpeedControl OptimalSpeedReachedHandler;


        protected int optimalspeed;
        protected int optimalheight;
        protected int speed;
        protected double height;
        public abstract int Speed { get; set; }
        public abstract double Height { get; set; }
        public int OptimalSpeed { get => optimalspeed; set => optimalspeed = value; }
        public int OptimalHeight { get => optimalheight; set => optimalheight = value; }
        public Plane(int optimalspeed, int optimalheight)
        {
            this.optimalspeed = optimalspeed;
            this.optimalheight = optimalheight;
        }
        public abstract void Flight();
        



    }
    class Airliner : Plane
    {
        public override event HeightReached HeightReachedHandler;
        public override event SpeedControl OptimalSpeedReachedHandler;
        public  event SpeedControl OptimalSpeedExceedHandler;
        public  event SpeedControl LowSpeedHandler;

        private int numberofpassangers;
        public int NumberOfPassangers { get => numberofpassangers; set => numberofpassangers = value; }


        public Airliner(int optimalspeed,int optimalheight) : base(optimalspeed, optimalheight) { }
        
        public override int Speed
        {
            get => this.speed;
            set
            {
                if (this.speed < optimalspeed && value == optimalspeed)
                {

                    this.speed = value;
                    OptimalSpeedReachedHandler.Invoke();
                }
                else if (value > optimalspeed)
                {
                    this.speed = value;
                    OptimalSpeedExceedHandler.Invoke();
                }
                else if(this.speed>=optimalspeed && value < optimalspeed)
                {
                    this.speed = value;
                    LowSpeedHandler.Invoke();

                }
                else this.speed = value;
            }
        }
        public override double Height
        {
            get => this.height;

            set
            {
                if (value >= optimalheight)
                {
                    this.height = value;
                    HeightReachedHandler.Invoke();
                }
                else
                    this.height = value;
            }
        }
        public override void Flight()
        {
            bool flag = false;

            while (true)
            {
                int SpeedIncrease = 100;
                int SpeedDecrease = 100;
                Random rand = new Random();
                int p = rand.Next(1, 10);

                if (this.Height < this.OptimalHeight)
                    this.Height += 1000;

                if (flag == false)
                {
                    this.Speed += SpeedIncrease;
                }
                if (this.Speed >= this.OptimalSpeed)
                    flag = true;

                if (p == 1 && flag == true)
                {
                    this.Speed += SpeedIncrease;
                }
                if (p == 2 && flag == true)
                {
                    this.Speed -= SpeedDecrease;
                }
                Console.WriteLine("Plane is flying at {0} km/h. Height:{1} meters.\n", this.Speed, this.Height);

                Thread.Sleep(2000);

            }
        }
    }

    class Fighter : Plane
    {
        public override event SpeedControl OptimalSpeedReachedHandler;
        public event SpeedControl RocketThrownHandler;
        public override event HeightReached HeightReachedHandler;
        private int numberofrockets;
        public int NumberOfRockets { get => numberofrockets; set => numberofrockets = value; }
        public override int Speed
        {
            get => speed;
            set
            {
                if (value == optimalspeed)
                {
                    this.speed = value;
                    OptimalSpeedReachedHandler.Invoke();
                }
                else
                    this.speed = value;
            }
        }
        public override double Height
        {
            get => height;
            set
            {
                if (value == optimalheight)
                {
                    this.height = value;
                    HeightReachedHandler.Invoke();
                }
                this.height = value;
            }
        }
        public Fighter(int optimalspeed, int optimalheight, int numberofrockets) : base(optimalspeed, optimalheight)
        {
            this.numberofrockets = numberofrockets;
        }

        public override void Flight()
        {
            while (true)
            {
                int SpeedIncrease = 100;
                Random rand = new Random();
                int p = rand.Next(1, 5);

                if (this.Height < this.OptimalHeight)
                    this.Height += 1000;

                if (this.Speed < OptimalSpeed)
                {
                    this.Speed += SpeedIncrease;

                }

                if (p == 1)
                {
                    if (numberofrockets > 0)
                    {
                        RocketThrownHandler.Invoke();
                        this.NumberOfRockets--;
                    }
                    else
                        Console.WriteLine("Fighter is out of rockets");
                }

                Console.WriteLine("Plane is flying at {0} km/h. Height:{1} meters.\n", this.Speed, this.Height);

                Thread.Sleep(2000);

            }

        }


    }
}
