using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task1();
            // Task2();
            // Task3();
            // Task4();
            // Task5();
            // Task6();
            // Task7();
            // Task8();
        }
        static void Task1()
        {
            List<int> numbers = new List<int>(20);
            for (int i = 0; i < 100; i++)
            {

                numbers.Add(i + 1);
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 10 == 0)
                {
                    numbers.RemoveAt(i);
                }
            }
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
        static void Task2()
        {
            Car car1 = new Car("Ford", "Focus", "CTCTCTCT", 5);
            Car car2 = new Car("Ford", "Mustang", "12345678", 4);
            Car car3 = new Car("Opel", "Astra", "AC7777PA", 5);

            List<Car> carlist = new List<Car>();
            carlist.Add(car1);
            carlist.Add(car2);
            carlist.Add(car3);

            foreach (Car c in carlist)
            {
                Console.WriteLine("Model: {0}, Brand: {1}, Registration Number {2}, Number of seats {3}. ",
                    c.Model, c.Brand, c.RegNumber, c.SeatsNumber);
            }
        }
        static void Task3()
        {
            Bike bike1 = new Bike("Brand1", "Model1", "Red");
            Bike bike2 = new Bike("Brand1", "Model2", "Green");
            Bike bike3 = new Bike("Brand1", "Model3", "Blue");

            LinkedList<Bike> bikelist = new LinkedList<Bike>();

            bikelist.AddLast(bike2);
            bikelist.AddLast(bike3);

            LinkedListNode<Bike> node = bikelist.Find(bike2);
            bikelist.AddBefore(node, bike1);
            foreach (Bike b in bikelist)
            {
                Console.WriteLine("Model: {0}, Brand: {1}, Colour {2}. ",
                    b.Model, b.Brand, b.Colour);
            }
        }
        static void Task4()
        {
            #region Stack
            Console.WriteLine("Stack reverse:");
            Stack<int> numberStack = new Stack<int>();
            for(int i =0; i<50; i++)
            {
                numberStack.Push(i+1);
            }
            for (int i = 0; i < 50; i++)
            {
                Console.Write(numberStack.Pop()+" ");
            }
            Console.WriteLine("\n");
            #endregion

            #region List
            Console.WriteLine("List reverse:");
            List<int> numberLIst = new List<int>();
            for (int i = 0; i < 50; i++)
            {
                numberLIst.Add(i + 1);
            }
            numberLIst.Reverse();
            for (int i = 0; i < 50; i++)
            {
                Console.Write(numberLIst[i]+" ");
            }
            Console.WriteLine("\n");
            #endregion

            #region Queue
            Console.WriteLine("Queue reverse:");
            Queue<int> numberQueue = new Queue<int>();
            for (int i = 0; i < 50; i++)
            {
                numberQueue.Enqueue(i + 1);
            }
            numberQueue.Reverse();

            for (int i = 49; i>=0; i--)
            {
                Console.Write(numberQueue.ElementAt(i)+" ");
            }
            Console.WriteLine("\n");
            #endregion

        }
        static void Task5()
        {

            /* Създайте си структурата опашка и я напълнете с числата от 1 до 10.
             След това обходете опашката и изтрийте елементите, докато текущия елемент
            не стане равен на числото 5.Когато стане 5 принтирайте, че това е което търсите и спрете обхождането.*/

            Queue<int> queueNumber = new Queue<int>();

            for(int i= 0; i<10; i++)
            { 
                queueNumber.Enqueue(i + 1);
            }
            for(int i=0; i<10; i++)
            {
                if (queueNumber.Peek() == 5)
                {
                    Console.WriteLine("Number 5 found.");
                    break;
                }
                Console.WriteLine("Dequeing " + queueNumber.Dequeue());
            }

        }
        static void Task6()
        {
            /*
            6.Напишете програма, която обръща думите в едно изречение на обратно. Използвайте стек.          
            Пример: I am from planet Eartх
            Решение: Earth planet from am I*/

            string p = "I am from planet Earth";
            Stack<string> reverseOrderStack = new Stack<string>();
            int counter = 0;
            foreach(string s in p.Split(' '))
            {
                reverseOrderStack.Push(s);
                counter++;
            }
            for(int i=0; i<counter; i++)
            {
                Console.Write(reverseOrderStack.Pop()+" ");
            }
            Console.Write("\n");


        }
        static void Task7()
        {
         
            string p = "My spaceship is ready for travelling to Mars";
            Queue<string> q = new Queue<string>();
            int counter = 0;

            foreach (string s in p.Split(' '))
            {
                if (s.Length > 3)
                {
                    q.Enqueue(s);
                    counter++;
                }
            }
            for(int i=0; i<counter; i++)
            {
                Console.Write(q.Dequeue()+" ");
            }
            Console.WriteLine();

        }
        static void Task8()
        {
            List<string> s = new List<string>();
            s.Add("f");
            s.Add("d");
            Console.WriteLine("List_Index"+s.IndexOf("g"));
           
            MyList<string> p = new MyList<string>();
         
            p.Add("MyList - 0");
            p.Add("MyList - 1");
            p.Add("MyList - 2");
            p.Add("MyList - 2");
            p.Add("MyList - 2");
            p.Add("MyList - 2");
            p.Add("MyList - 2");

            Console.WriteLine("Count " + p.Count);
            p.Clear();
            Console.WriteLine("Count " + p.Count);
            p.Add("1");
            p.Insert(1, "d");
            


            Console.WriteLine("Number of elements in array: " + p.Count);
            Console.WriteLine("First: "+p[0]);
            Console.WriteLine("Second: " + p[1]);


            MyStack<string> stack = new MyStack<string>();
            stack.Push("1");
            stack.Push("2");
            stack.Push("3");
            stack.Push("3");
            stack.Push("3");
            stack.Push("3");
            stack.Push("3");
            stack.Push("3");

            Console.WriteLine("Stack Count " + stack.Count);
            Console.WriteLine("Peek "+stack.Peek());
            Console.WriteLine("Pop "+stack.Pop());
            Console.WriteLine("Peek " + stack.Peek());
            Console.WriteLine("Pop " + stack.Pop());
            Console.WriteLine("Peek " + stack.Peek());
            Console.WriteLine("Pop " + stack.Pop());
            Console.WriteLine("Stack Count " + stack.Count);


            MyQueue<int> qu = new MyQueue<int>();

            qu.Enqueue(2);
            qu.Enqueue(3);
            qu.Enqueue(4);
            qu.Enqueue(5);
            qu.Enqueue(6);
            Console.WriteLine("Element at"+qu.ElementAt(0));

            Console.WriteLine("PeekQu "+qu.Peek());
            Console.WriteLine("CountQu " + qu.Count);
            Console.WriteLine("DeQu " + qu.Dequeue());
            Console.WriteLine("Element at" + qu.ElementAt(0));

            Console.WriteLine("DeQu " + qu.Dequeue());
            Console.WriteLine("Element at" + qu.ElementAt(0));

            Console.WriteLine("DeQu " + qu.Dequeue());
            Console.WriteLine("Element at" + qu.ElementAt(0));

            Console.WriteLine("DeQu " + qu.Dequeue());
            Console.WriteLine("PeekQu " + qu.Peek());
            Console.WriteLine("CountQu " + qu.Count);
            Console.WriteLine("Element at" + qu.ElementAt(0));
            Console.WriteLine("DeQu " + qu.Dequeue());



        }
    }


}
