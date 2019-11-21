using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    public abstract partial class Person:IComparable
    {
        private static int counter = 0;
        protected string name;
        protected string surename;
        protected int workexperience;

        public Person() { counter++; }
        public Person(string name, string surename, int workexperience)
        {
            
            this.name = name;
            this.surename = surename;
            if (workexperience < 0)
            {
                throw new Exception("Person cannot have less than zero years of work experience.");
            }
            else
            {
                this.workexperience = workexperience;
            }
            counter++;

        }
        public string Name { get { return this.name; } set { this.name = value; } }
        public string SureName { get { return this.surename; } set { this.surename = value; } }
        public int WorkExperience
        {
            get
            {
                return this.workexperience;
            }
            set
            {                
                if (value < 0)
                {

                    throw new Exception("Person cannot have less than zero years of work experience.");
                }
                else
                {
                    this.workexperience = value;
                }

            }
        }
        public static int NumberOfInstances()
        {
            return counter;
        }

        

    }

}
