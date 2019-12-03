using System;
using System.Collections.Generic;
using System.Runtime;
using System.Runtime.Versioning;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Collections.ObjectModel;
using System.Security.Permissions;


namespace Homework13
{
    class MyList<T>
    { /* Имплементирайте клас MyList, който вътрешно да пази данните в масив.
                Нека има основните операции от вградения List – Add, Insert, InsertAt, 
            Remove, RemoveAt, Clear, IndexOf, оператор за индексиране – [].
             Нека списъка се оразмерява динамично.*/
        private T[] TypeArray = new T[4];
        private int index = 0;
        public T this[int ind]
        {
            get
            {
                if (ind >= this.Count)
                    throw new ArgumentOutOfRangeException();

                return TypeArray[ind];
            }
            set
            {
                if (ind >= this.Count)
                    throw new ArgumentOutOfRangeException();

                TypeArray[ind] = value;
            }
        }
 
        public int Count
        {
            get
            {
                int counter = 0;
                foreach (T element in TypeArray)
                    if (!EqualityComparer<T>.Default.Equals(element, default(T)))
                        counter++;

                return counter;
            }
        }
        public void Add(T val)
        {
            if (TypeArray[TypeArray.Length - 1] != null || TypeArray[TypeArray.Length - 2] != null)
            {
                T[] CopyArray = new T[TypeArray.Length];
                CopyArray = TypeArray;
                TypeArray = new T[TypeArray.Length * 2];
                for (int i = 0; i < CopyArray.Length; i++)
                {
                    TypeArray[i] = CopyArray[i];
                }
            }
            TypeArray[index] = val;
            index++;
        }
        public void Insert(int ind, T val)
        {
       
            if (ind > this.Count)
            {
                throw new ArgumentOutOfRangeException();
                          
            }

            if (TypeArray[TypeArray.Length - 1] != null || TypeArray[TypeArray.Length - 2] != null)
            {
                T[] CopyArray = new T[TypeArray.Length];
                CopyArray = TypeArray;
                TypeArray = new T[TypeArray.Length * 2];
                for(int i=0; i<CopyArray.Length; i++)
                {
                    TypeArray[i] = CopyArray[i];
                }
            }
            for (int i = TypeArray.Length-2; i >=ind; i--)
            {
                if (TypeArray[i] != null)
                {
                    T oldval = TypeArray[i];
                    TypeArray[i + 1] = oldval;
                }
            }
            TypeArray[ind] = val;
            index++;
        }
        public void Remove(T val)
        {
            for(int i=0; i<this.Count;i++)
            {
                if (TypeArray[i].Equals(val))
                {
                    for (int k = i; k <this.Count; k++)
                    {
                        if (k == this.Count - 1)
                        {
                            TypeArray[k] = default(T);
                        }
                        if (TypeArray[k] != null)
                        {
                            TypeArray[k] = TypeArray[k + 1];
                        }
                    }

                }
            }

        }
        public void RemoveAt(int ind)
        {
            if (ind >= this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            for(int i=ind; i<this.Count; i++)
            {
                if (i == this.Count - 1)
                {
                    TypeArray[i] = default(T);
                }

                T val = TypeArray[i+1];
                TypeArray[i] = val;
                
            }
        }
        public void Clear()
        {
            Array.Clear(TypeArray, 0, this.Count);
            index = 0;

        }
        public int IndexOf(T val)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (TypeArray[i].Equals(val))
                    return i;
            }
                    return -1;
        }


    }
}
