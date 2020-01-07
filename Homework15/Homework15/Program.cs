using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework15
{
    class Program
    {
        static void Main(string[] args)
        {
            //task1();
            task2(new DateTime(2000,9,24));
           // task3();
        }

        private static void task2(DateTime dt)
        {

            float value = (float)dt.Month + (float)dt.Day / 100;   // <month>.<day(2 digit)>
            if (value < 3.21 || value >= 12.22)
            {
                Console.WriteLine(Seasons.winter);
                return;
            }  // Winter
            if (value < 6.21)
            {
                Console.WriteLine(Seasons.spring);
                return;
            }// Spring
            if (value < 9.23)
            {
                Console.WriteLine(Seasons.summer);
                return;
            }
            Console.WriteLine(Seasons.autumn);
            return;
            
        }

        private static void task3()
        {
            Student stud1 = new Student(1, "Ivan", 111);
            Student stud2 = new Student(2, "Stoyan", 222);
            Student stud3 = new Student(3, "Petar", 333);

            StudentManagament st = new StudentManagament();
            st.Create(stud1);
            st.Delete(1);

           // Console.WriteLine(st.Read(2).StudentName);

        }

        private static void task1()
        {
            try
            {
                int p = Int32.Parse(Console.ReadLine());
                if (p < 1 || p > 12)
                    throw new ArgumentOutOfRangeException();
                Months m;
                Enum.TryParse(p.ToString(), out m);
                Console.WriteLine(m);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
