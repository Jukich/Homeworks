using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    public class Teacher : Person,IPerson
    {
        private string subject;
        public string Subject { get { return this.Subject; } set { this.subject = value; } }

        public Teacher() { }

        public Teacher(string name, string surename, string subject,int workexperience):base(name,surename,workexperience)
        {
            this.subject = subject;
        }

        public virtual void HomeworkCheck()
        {
            Random rnd = new Random();
            int mark = rnd.Next(2, 6);
            if (this.subject == null)
            {
                Console.WriteLine("Homework was checked by {0} {1} {2}. Mark is {3}.",
                     this.GetType().Name,this.name, this.surename, mark);
            }
            else
            {
                Console.WriteLine("{0} homework was checked by {1} {2} {3}. Mark is {4}.",
                    this.subject, this.GetType().Name, this.name, this.surename, mark);
            }
        }

        void IPerson.HomeworkCheck()
        {
            Console.WriteLine("I'm just a Person now and I cannot check your homework.");
        }

        public void HalloGreeting()
        {
            Console.WriteLine("Hallo students, I'm your {0} {1} {2} {3}.",this.subject, this.GetType().Name, this.name, this.surename);
        }
        void IPerson.HalloGreeting()
        {
            Console.WriteLine("Hallo, I'm person {0} {1}.", this.name, this.surename);
        }

        public virtual void ByeGreeting()
        {
            Console.WriteLine("Goodbye students, see you again in my {0} class.", this.subject);
        }

    }

   /* Създайте два класа SchoolTeacher и CollegeTeacher, които да наследяват Teacher.
 Нека SchoolTeacher да има допълнително поле за списък от 5 текстови полета, които да пазят до 5 класа(„2А“ или „3Б“) и 
 метод, който да казва кои са тези класове.
Нека CollegeTeacher да има поле, което да пази информация за колежа в който преподава.
Нека SchoolTeacher и CollegeTeacher да извеждат същото съобщение като това на Teacher при проверка на домашните.
Нека SchoolTeacher да може да забавлява децата.Нека Assistant да може да пише научни статии.
Нека SchoolTeacher и CollegeTeacher да имат подходящи конструктори.*/

    class SchoolTeacher : Teacher ,IPerson
    {
        private List<string> grades = new List<string>();
        public List<string> Grades { get { return grades; }
            set
            {
                if ((value.Count + grades.Count) > 5)
                    throw new Exception("School teacher cannot teach more than 5 grades.");
                else
                    this.grades = value;
                
            }

        }

        public SchoolTeacher() { }

        public SchoolTeacher(string name, string surename, string subject, int workexperience,List<string> grades) : base(name, surename,subject, workexperience)
        {
            this.grades = grades ;
        }

        public void show()
        {
            Console.Write("{0} {1} {2} teaches grades ",this.GetType().Name,this.name,this.surename);
            foreach (string str in Grades)
                Console.Write(str+ " ");
            Console.WriteLine(".");
            
        }

        public void HaveFun()
        {
            Console.WriteLine("Students, it's time to have some fun.");

            Random rdm = new Random();
            int f = rdm.Next(0, 4);

            string[] fun = new string[5];
            fun[0]="It's time to play football";
            fun[1] = "Let's play hide and seek.";
            fun[2] = "I think it's good time to go outside and breath some fresh air.";
            fun[3] = "I'll dress up like clown and entertain you.";
            fun[4] = "I'll let everyone do whatever he wants.";

            Console.WriteLine(fun[f]);
           
        }

    }

    class CollegeTeacher : Teacher, IPerson
    {

        private string college;
        public string College { get { return college; } set { this.college = value; } }
        public CollegeTeacher() { }

        public CollegeTeacher(string name, string surename, string subject, int workexperience, string college)
            : base(name, surename, subject, workexperience)
        {
            this.college = college;
        }

    }

}
