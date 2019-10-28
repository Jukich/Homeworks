using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class QueueCustom
    {
        private const int initialCapacity = 3;
        private int[] arr;
        private int first;
        private int last; 

        public QueueCustom()
        {
            first = 0;
            last = -1;
            arr = new int[initialCapacity];
        }

        public int Enqueue(int value)
        {
            if (last + 1 == arr.Length)
            {
                int[] newArray = new int[arr.Length * 2];

                for (int i = 0; i < arr.Length; i++)
                {
                    newArray[i] = arr[i];
                }

                arr = newArray;
            }

            last++;
            arr[last] = value;
            return value;

        }

        public int Dequeue()
        {
          
                if (last < first)
                {
                    throw new IndexOutOfRangeException("Queue is empty");
                }
          

            int value = arr[first];
            first++;
            return value;

        }

        public int Peek()
        {

            if (last < first)
            {
                throw new IndexOutOfRangeException("Queue is empty");
            }

            return arr[first];
        }

        public int Size
        {
            get { return last -first +1; }
        }

        public int ElementAt(int value)
        {
            if(value<0 || value > this.Size-1)
            {
                throw new IndexOutOfRangeException("Argument out of range");
            }
            return arr[first + value];
        } 

        public bool Contains(int value)
        {
            for(int i=first; i<=last; i++)
            {
                if (arr[i] == value)
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
            arr = null;
            arr = new int[initialCapacity];
        }

    }
}
