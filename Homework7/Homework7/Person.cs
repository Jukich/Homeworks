using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Person
    {
        private string name;
        private ulong egn;
        private int years;
        private string email;

        public string Name { get { return name; } set { name = value; } }
        public ulong Egn { get { return this.egn; } set { egn = value; } }
        public int Years { get { return years; } set { years = value; } }
        public string Email { get { return email; } set { email = value; } }

        public Person(string name, ulong egn, int years, string email)
        {
            this.name = name;
            this.egn = egn;
            this.years = years;
            this.email = email;
        }

        public void ShowPerson()
        {
            Console.WriteLine("Name of person is " + name + ", he is " + years + " years and his email is " + email);
        }

    }
}
