using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
  
    class Paper
    {
        private int yearofcreation;
        private int pagesnumber;

        public int YearOfCreation { get { return yearofcreation; } set { yearofcreation = value; } }
        public int PagesNumber { get { return pagesnumber; } set { pagesnumber = value; } }

        public Paper(int yearofcreation, int pagesnumber)
        {
            this.yearofcreation = yearofcreation;
            this.pagesnumber = pagesnumber;
        }

    }


    class Book:Paper
    {
        private string title;
        private string author;

        public string Title { get { return title; } set { title = value; } }
        public string Author { get { return author; } set { author = value; } }


        public Book(string title, string author,int yearofcreation, int pagesnumber) : base(yearofcreation,pagesnumber)
        {
            this.title = title;
            this.author = author;

        }
        public static void PrintPage(Book bk, int page)
        {
            Console.WriteLine("Page " + page + " from book " + bk.Title + " will be printed\n");
        }

    }
    class Journal:Paper
    {
        private int numberofstudents;
        private string teachername;

        public int NumberOfStudents { get { return numberofstudents; } set { this.numberofstudents = value; } }
        public string TeacherName { get { return teachername; } set { this.teachername = value; } }

        public Journal(int numberofstudents, string teachername, int yearofcreation, int pagesnumber): base(yearofcreation, pagesnumber)
        {
            this.numberofstudents = numberofstudents;
            this.teachername = teachername;
        }

        public static void PrintYearMarks(int[] marksArr)
        {
            int p=0;
            foreach (int i in marksArr)
            {
                p += i;
            }
            Console.WriteLine("Avverage mark is {0:N2}" , (double)p /marksArr.Length);
            
        }

    }
}