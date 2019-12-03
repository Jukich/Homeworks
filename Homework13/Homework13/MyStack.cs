using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{
    class MyStack<T>
    {/*Имплементирайте клас MyStack, 
        който да има основните операции за стек – Push, Pop, Peek, Size.  
        Нека стека се оразмерява динамично.*/
        private T[] TypeArray = new T[3];
        private int last = 0;

        public int Count {
            get
            {
                int counter = 0;
                foreach (T element in TypeArray)
                {
                    if (!EqualityComparer<T>.Default.Equals(element, default(T)))
                    {
                        counter++;
                    }
                }
                return counter;
            }
        }

        public void Push(T val)
        {
            try
            {
                TypeArray[last] = val;
            }
            catch (IndexOutOfRangeException ex)
            {           
                T[] CopyArray = new T[TypeArray.Length];
                CopyArray = TypeArray;
                TypeArray = new T[TypeArray.Length * 2];
                for (int i = 0; i < CopyArray.Length; i++)
                {
                    TypeArray[i] = CopyArray[i];
                }
                TypeArray[last] = val;
            }
            finally
            {
                last++;
            }

        }
         
        public T Pop()
        {

            if (Count == 0)
            {
                throw new InvalidOperationException("Stack empty");
            }            

            last--;
            T val = TypeArray[last];
            TypeArray[last] = default(T);
            return val;

        }

        public T Peek()
        {
            if (Count == 0)
                throw new InvalidOperationException("Stack Empty");
            return TypeArray[last - 1];
        }

    }
}
