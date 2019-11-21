using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    class Program
    {
        static void Main(string[] args)
        {
            Policeman pol = new Policeman("Ivan", 40, 150, 6, "director");
            pol.Rang = "sergeant";
            Console.WriteLine("Police name is {0}, he is {1} years old, his rank is {2} and his salary is {3}.",
                pol.Name, pol.Years, pol.Rang, pol.CalculateSalary());

            Doctor doc = new Doctor("Petar", 50, 200, 5, 12, 12);
              Console.WriteLine("Docotr name is {0}, he is {1} years old, he works {2} dayshifts and {3} nightshifts" +
                  "and his salary is {4}.",
                doc.Name, doc.Years, doc.DayShifts, doc.NightShifts, doc.CalculateSalary());

            Book book1 = new Book("Pod igoto", "Ivan Vazov", 1895, 400);
            Console.WriteLine("\nBook title is " + book1.Title + ", it's author is " + book1.Author
                             + " books, its year of creation is " + book1.YearOfCreation + " and has "+book1.PagesNumber+" pages.");
            Book.PrintPage(book1, 5);


            Journal jou = new Journal(30,"Ivan",2015,50);
            Journal.PrintYearMarks(new[] { 1, 2, 3, 4, 5,6,5 });


            Console.ReadLine();
        }
    }
}
