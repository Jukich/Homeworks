using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{
    class MyQueue<T>
    {

        private T[] TypeArray = new T[3];
        private int last = 0;
        private int first = 0;
        public int Count
        {
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


        public void Enqueue(T value)
        {
            try
            {
                TypeArray[last] = value;
            }
            catch
            {
                T[] CopyArray = new T[TypeArray.Length * 2];
                CopyArray = TypeArray;
                TypeArray = new T[TypeArray.Length * 2];

                for (int i = 0; i < CopyArray.Length; i++)
                    {
                        TypeArray[i] = CopyArray[i];
                    }
                TypeArray[last] = value;

            }
            finally
            {
                last++;
            }
        }
    

        public T Dequeue()
        {

            if (Count==0)
            {
                throw new IndexOutOfRangeException("Queue is empty");
            }

            T value = TypeArray[0];
            for(int i=0; i<TypeArray.Length-1; i++)
            {

                TypeArray[i] = TypeArray[i+1];

            }

            TypeArray[this.Count] = default(T);
            return value;

        }

        public T Peek()
        {

            if (Count==0)
            {
                throw new IndexOutOfRangeException("Queue is empty");
            }

            return TypeArray[0];
        }

        public T ElementAt(int value)
        {
            if (value < 0 || value > this.Count - 1)
            {
                throw new IndexOutOfRangeException("Argument out of range");
            }
            return TypeArray[first + value];
        }

        public bool Contains(int value)
        {
            for (int i = first; i <= last; i++)
            {
                if (TypeArray[i].Equals(value))
                {
                    return true;
                }
            }
            return false;
        }

        public void Clear()
        {
            first = 0;
            last = -1;
            Array.Clear(TypeArray, 0, this.Count);
        }

    }

}
