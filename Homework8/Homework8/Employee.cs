using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    class Employee
    {
        private string name;
        private int years;
        private double workhours;
        private double salaryperhour;
        private double totalsalary;
        protected double salary_multiplier;

        public Employee(string name, int years, double workhours, double salaryperhour)
        {
            this.name = name;
            this.years = years;
            this.workhours = workhours;
            this.salaryperhour = salaryperhour;

        }

        public string Name { get { return name; } set { this.name = value; } }
        public int Years { get { return years; } set { this.years = value; } }
        public double WorkHours { get { return workhours; } set { this.workhours = value; } }
        public double SalaryPerHour { get { return salaryperhour; } set { this.salaryperhour = value; } }

        public virtual double CalculateSalary()
        {

            totalsalary = salaryperhour*workhours;
            return totalsalary;
            
        }


    }

    class Policeman : Employee
    {
        private string rang;
        public string Rang { get { return rang; } set { this.rang = value; SetMultiplier(); } }

        public Policeman(string name, int years, double workhours, double salaryperhour, string rang) :
            base(name, years, workhours, salaryperhour)
        {
           
            this.rang = rang;
            SetMultiplier();
 
        }
        public void SetMultiplier()
        {
            switch (this.rang)
            {
                case "sergeant":
                    salary_multiplier = 1.2;
                    break;
                case "inspector":
                    salary_multiplier = 1.5;
                    break;
                case "director":
                    salary_multiplier = 2;
                    break;
                default:
                    salary_multiplier = 1.0;
                    break;
            }

        }


        public override double CalculateSalary()
        {
            return base.CalculateSalary()*salary_multiplier;
        }


    }

    class Doctor : Employee
    {
        private int dayshifts;
        private int nightshifts;
        private double nightshiftbonus;
        public Doctor(string name, int years, double workhours, double salaryperhour, int dayshifts, int nightshifts) :
            base(name, years, workhours, salaryperhour)
        {
            this.dayshifts = dayshifts;
            this.nightshifts = nightshifts;
            nightshiftbonus = nightshifts * 10;

        }
        public int DayShifts { get { return dayshifts; } set { this.dayshifts = value; } }
        public int NightShifts { get { return nightshifts; } set { this.nightshifts = value; } }


        public override double CalculateSalary()
        {
            return base.CalculateSalary() + nightshiftbonus;
        }

    }
}
