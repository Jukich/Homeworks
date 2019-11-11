using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    /*Създайте клас Lecturer, който наследява Person и добавя наименование на университет, в който преподава. 
Класа Lecturer също трябва да има метод за проверка на домашни.  Класа Lecturer трябва да има 3 метода за
провеждане на упражнения. Методите трябва да са с едно и също име на различен брой параметри.
Класа Lecture трябва да има поне 2 конструктора (с и без параметри).Класа Lecturer трябва да има метод за 
поздрав само за добър ден. Нека всички Lecturers да имат поле, което не може да се изменя и което да съдържа 
информация за максимален брой лекции на седмица (примерно 10). 
*/
    class Lecturer:Person ,IPerson
    {
        private const int lecturesperweek = 10;
        private string university;
        public string University { get { return this.university; } set { this.university = value; } }
        public int LecturesPerWeek { get { return lecturesperweek; } }

        public Lecturer() { }
        public Lecturer(string name, string surename, string university, int workexperience) : base(name, surename, workexperience)
        {
           
            this.university = university;
        }

        public virtual void HomeworkCheck()
        {
            Random rnd = new Random();
            int mark = rnd.Next(2, 6);
            Console.WriteLine("Homework was checked by {0} {1} {2}. Mark is {3}.",
            this.GetType().Name,this.name, this.surename, mark);
            
        }
        void IPerson.HomeworkCheck()
        {
            Console.WriteLine("I'm just a Person now and I cannot check your homework.");
        }

        public virtual void Exercise(double time, int numberofexercises, int numberofexams  )
        {
            Console.WriteLine("All exercises of {0} {1} start at {2}. Every student must attend to at least {3} exercises."
                +"  There will be {4} exams during the exercises." , this.name,this.surename, time,numberofexercises,numberofexams);
        }

        public virtual void Exercise(string subject, int protocolsnumber )
        {
            Console.WriteLine("Students without {0} protocols won't be allowed to attend the {1} exercise of {2} {3}.",
                protocolsnumber, subject,this.name, this.surename);
        }


        public void Exercise(string[] conspect)
        {
            int i = 1;
            Console.WriteLine("Discipline summary:");
            foreach(string str in conspect)
            {
                Console.WriteLine(i + "." + str);
                i++;
            }
        }

        public void HalloGreeting()
        {
            Console.WriteLine("Hallo students, I'm your {0} {1} {2}.", this.GetType().Name, this.name, this.surename);
        }
        void IPerson.HalloGreeting()
        {
            Console.WriteLine("Hallo, I'm person {0} {1}.", this.name, this.surename);
        }


    }
    /*Създайте два класа Professor и Assistant, които да наследяват Lecturer.
Нека Professor да има допълнително поле за титла и метод, който да казва каква е титлата и колко години трудов стаж има.
Нека Assistant да има поле, което да пази информация, дали той е главен асистент или не е.
Нека Assistant да има и метод, който да казва как се казва и дали е главен асистент.
Нека класа Person да има брояч, който да знае колко обекта от неговите наследници са създадени.
Добавете проверка към цялата система, така че да не могат да се създават потребители с отрицателен брой години трудов стаж.
*/
    class Professor: Lecturer,IPerson
    {
      //  private static int[] ProfessorID = new int[100];
        public int numberofexams = 0;
        private const string title = "Professor";
        public string Title { get { return title; } }

        public Professor() {  }
        public Professor(string name, string surename, string university, int workexperience) : 
            base(name, surename,university, workexperience)
        {
            
        }

       public override void HomeworkCheck()
        {
            Console.WriteLine("Professor {0} {1} gives you low mark.", this.name, this.surename);
        }

        void IPerson.HomeworkCheck()
        {
            Console.WriteLine("I'm just a Person now and I cannot check your homework.");
        }


        public void ProfesorInfo()
        {    
            Console.WriteLine("This is {0} {1} {2}. The {3} has {4} years of work experience.",
                this.Title,this.name,this.surename,this.Title, this.workexperience);
        }
        public int GiveExam(int NumberOfStudents)
        {
            Console.WriteLine("Exam was held by profesor {0} {1}. A total of {2} students took the exam.",this.name,this.surename,NumberOfStudents);
            Console.WriteLine("The exams will be checked by one of the assistants.");
            numberofexams += NumberOfStudents;
            return NumberOfStudents;
        }
    }

    class Assistant : Lecturer, IPerson
    {
        private bool ismainassistant;

        public bool IsMainAssistant { get { return true; } set { this.ismainassistant = value; } }
        public Assistant() { }
        public Assistant(string name, string surename, string university, int workexperience, bool ismainassistant) :
            base(name, surename, university, workexperience)
        {
            this.ismainassistant = ismainassistant;
        }

        public override void HomeworkCheck()
        {
            Console.WriteLine("I'm an assistant and I will give you excelent mark for your homework.");
        }
        void IPerson.HomeworkCheck()
        {
            Console.WriteLine("I'm just a Person now and I cannot check your homework.");
        }

        public void AssistantInfo()
        {
            Console.WriteLine(ismainassistant ? "Assistant name is " + this.name + " " + this.surename + "and he is main assistant" :
                        "Assistant name is " + this.name + " " + this.surename + " and he is not main assistant.");
        }
        
        public void AcademicArticle(string topic)
        {
            Console.WriteLine("This is academic article by assistant {0} {1} about {2}.", this.name, this.surename, topic);
        }

        public void CheckExam(Professor pro)
        {
            Console.WriteLine("All {0} exams held by professor {1} {2} were checked by assistant {3} {4}",
                pro.numberofexams,pro.Name,pro.SureName,this.name,this.surename);
           
        }
    }
}