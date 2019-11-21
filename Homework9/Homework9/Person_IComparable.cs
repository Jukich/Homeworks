using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    partial class Person
    {
        public class SotrByAscending : IComparer<Person>
        {
            int IComparer<Person>.Compare(Person a, Person b)
            {
                Person p1 = (Person)a;
                Person p2 = (Person)b;

                if (p1.WorkExperience > p2.WorkExperience)
                    return 1;

                if (p1.WorkExperience < p2.WorkExperience)
                    return -1;

                else
                    return 0;

            }
        }

        private class sortByDescending: IComparer<Person>
        {
            int IComparer<Person>.Compare(Person a, Person b)
            {
                Person p1 = (Person)a;
                Person p2 = (Person)b;

                if (p1.WorkExperience < p2.WorkExperience)
                    return 1;

                if (p1.WorkExperience > p2.WorkExperience)
                    return -1;

                else
                    return 0;
            }
        }

        private class sortBySurename : IComparer<Person>
        {
            int IComparer<Person>.Compare(Person a, Person b)
            {
                Person p1 = (Person)a;
                Person p2 = (Person)b;
                return String.Compare(p1.SureName, p2.SureName);
            }
        }

        int IComparable.CompareTo(object obj)
        {
            Person p = (Person)obj;
            return String.Compare(this.Name, p.Name);
        }
        public static IComparer<Person> SortSurename()
        {
            return (IComparer<Person>)new sortBySurename();

        }

        public static IComparer<Person> sortAscending()
        {
            return (IComparer<Person>)new SotrByAscending();

        }
        public static IComparer<Person> sortDescending()
        {
            return (IComparer<Person>)new sortByDescending();
        }
 

    }
}
