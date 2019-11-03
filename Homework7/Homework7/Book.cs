using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Book
    {
        private string title;
        private string author;
        private int yearofcreation;
        private int pagesnumber;

        public string Title { get { return title; } set { title = value; } }
        public string Author { get { return author; } set { author = value; } }
        public int YearOfCreation { get { return yearofcreation; } set { yearofcreation = value; } }
        public int PagesNumber { get { return pagesnumber; } set { pagesnumber = value; } }

        public Book(string title, string author, int yearofcreation, int pagesnumber)
        {
            this.title = title;
            this.author = author;
            this.yearofcreation = yearofcreation;
            this.pagesnumber = pagesnumber;
        }

        public static void PrintPage(Book bk,int page)
        {
            Console.WriteLine("\nPage " + page + " from book "+ bk.Title+ " will be printed");
        }

    }
}
