using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Homework9
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Task1");
            Console.ForegroundColor = ConsoleColor.White;

            #region Task1

            Car car = new Car("Ford", 2002, "C1111", "Diesel", 0);
            car.StartTurbo();
            car.Drive(50);
            car.StopTurbo();
            car.NumberOfWheels = 4;
            Console.WriteLine("The car has " + car.NumberOfWheels + " wheels.");
            car.YearOfCreation = 2002;
            car.GetYears();
            Console.WriteLine();

            IVehicle motorbike = new Motorbike("Honda",2010,"PAAAAA","Gasoline");
            motorbike.YearOfCreation = 2012;
            motorbike.GetYears();
            motorbike.Drive(120);
            Console.WriteLine();


            #endregion

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Task2");
            Console.ForegroundColor = ConsoleColor.White;

            #region Task2
            Car CarAb = new Car("Opel",2010,"OB444AP","Diesel",4);
            CarAb.StartTurbo();
            CarAb.Drive(50);

            Motorbike MotorAb = new Motorbike("Yamaha",2011,"MOOTOOP","Hybrid");
            MotorAb.Drive(200);
            MotorAb.Name = "Yamaha";
            MotorAb.RegNumber = "MOOTOOP";
            MotorAb.YearOfCreation = 2008;
            MotorAb.engine = "Hybrid";
            

            IVehicle[] veh = new IVehicle[4];
            veh[0] = car;
            veh[1] = motorbike;
            veh[2] = CarAb;
            veh[3] = MotorAb;

            foreach (IVehicle iv in veh)
            {
                Console.WriteLine("Model: {0}, RegNumber: {1}, Year of creation {2}", iv.Name, iv.RegNumber, iv.YearOfCreation);
            }
            #endregion

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nTask3-IDisposable");
            Console.ForegroundColor = ConsoleColor.White;

            #region Task3-IDisposable
            IDisposableExample ex = new IDisposableExample();

            ex.LogWriter("d");
            ex.Dispose();
            try
            {
                ex.Write();
            }
            catch
            {
                Console.WriteLine("The streamwriter has already been disposed");
            }
            #endregion

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nTask4");
            Console.ForegroundColor = ConsoleColor.White;

            #region Task4

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("//" + Person.NumberOfInstances() + " instances of class Person are created.");
            Console.ForegroundColor = ConsoleColor.White;


            #region Teacher
            Teacher teacher1 = new Teacher();
            teacher1.Name = "Petar";
            teacher1.SureName = "Petrov";
            teacher1.Subject = "English";
            teacher1.HalloGreeting();
            teacher1.HomeworkCheck();
            teacher1.ByeGreeting();

            IPerson Iteacher1 = teacher1;
            Iteacher1.HalloGreeting();
            Iteacher1.HomeworkCheck();
            Console.WriteLine();


            Teacher teacher2 = new Teacher("Todor", "Todorov", "Chemistry", 25);
            teacher2.HalloGreeting();
            teacher2.ByeGreeting();

            #endregion

            #region Lecturer
            Console.WriteLine("\n");
            Lecturer lct = new Lecturer();
            lct.Name = "Ivan";
            lct.SureName = "Ivanov";
            lct.HalloGreeting();
            lct.HomeworkCheck();
            lct.Exercise("Maths", 5);
            lct.Exercise(15.45, 14, 2);
            string[] conspect = { "Intro to matrices ", "Complex numbers", "Integration", "Geometry" };
            lct.Exercise(conspect);
            Console.WriteLine();
            #endregion

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("//" + Person.NumberOfInstances() + " instances of class Person are created.");
            Console.ForegroundColor = ConsoleColor.White;

            #region Professor
            Professor pro = new Professor("Dumble", "Dore", "Hogwarts", 20);
            pro.WorkExperience = 250;
            pro.ProfesorInfo();
            (pro as IPerson).HalloGreeting();
            (pro as IPerson).HomeworkCheck();
            pro.HalloGreeting();
            pro.GiveExam(5);
            pro.GiveExam(3);
            Console.WriteLine();


            Professor pro1 = new Professor("Volde", "Mort", "Hogwarts", 200);
            pro1.HalloGreeting();
            pro1.HomeworkCheck();
            pro1.GiveExam(10);
            Console.WriteLine();
            #endregion

            #region Assistant
            Lecturer assist = new Assistant("Harry", "Potter", "Hogwarts", 5, false);
            assist.HalloGreeting();
            (assist as Assistant).AssistantInfo();
            assist.HomeworkCheck();
            (assist as Assistant).AcademicArticle("Magic");
            (assist as Assistant).CheckExam(pro);
            Console.WriteLine();
            #endregion

            #region SchoolTeacher
            SchoolTeacher schoolt = new SchoolTeacher("Vasil", "Vasielv", "History", 5, new List<string> { "1a", "2b", "3v", "3g" });
            schoolt.HalloGreeting();
            schoolt.Grades.Add("2g");
            schoolt.show();
            schoolt.HomeworkCheck();
            schoolt.HaveFun();
            schoolt.ByeGreeting();
            Console.WriteLine();
            #endregion

            #region CollegeTeacher
            Teacher collt = new CollegeTeacher("Anton", "Antonov", "Biology", 15, "American College");
            (collt as CollegeTeacher).HalloGreeting();
            collt.HomeworkCheck();
            collt.ByeGreeting();
            Console.WriteLine();
            #endregion

            (assist as Assistant).CheckExam(pro1);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("//" + Person.NumberOfInstances() + " instances of class Person are created.");
            Console.ForegroundColor = ConsoleColor.White;


            Person[] persons = new Person[8];
            persons[0] = teacher1;
            persons[1] = teacher2;
            persons[2] = lct;
            persons[3] = pro;
            persons[4] = pro1;
            persons[5] = assist;
            persons[6] = schoolt;
            persons[7] = collt;

            foreach (IPerson p in persons)
            {
                p.HalloGreeting();
            }

            Console.WriteLine("\n");

            foreach (Person p in persons)
            {
                if (p is Teacher )
                {
                    (p as Teacher).HalloGreeting();
                }
                if(p is Lecturer)
                {
                    (p as Lecturer).HalloGreeting();
                }
            }


            #endregion


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("IComparable/ICompare");
            Console.ForegroundColor = ConsoleColor.White;

            #region Task4-Icomparable
            Console.WriteLine("Default order");
            Array.Sort(persons);
            foreach (Person p in persons)
            {
                Console.WriteLine(p.Name + "\t" + p.SureName + " Work experience: " + p.WorkExperience);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Order by work experience - acsending:");
            Array.Sort(persons, Person.sortAscending());
            foreach (Person p in persons)
            {
                Console.WriteLine(p.Name +"\t" + p.SureName + " Work experience: " + p.WorkExperience);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Order by work experience - descending:");
            Array.Sort(persons, Person.sortDescending());
            foreach (Person p in persons)
            {
                Console.WriteLine(p.Name + "\t" + p.SureName + " Work experience: " + p.WorkExperience);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Order by surename:");
            Array.Sort(persons, Person.SortSurename());
            foreach (Person p in persons)
            {
                Console.WriteLine(p.SureName + "\t" + p.Name );
            }
            Console.WriteLine("\n");

            #endregion


            Console.ReadLine();
        }
    }
}
