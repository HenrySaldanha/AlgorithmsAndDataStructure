using System;

namespace Algorithms.DataStructure.Array
{
    public class SimpleArray<T>
    {
        public T[] Array;

        public SimpleArray() => Console.WriteLine($"Class: {GetType().Name}");


        public SimpleArray<T> Add(T key)
        {
            if(key == null) return this;

            if (Array is null)
            {
                Array = new T[] { key };
                return this;
            }
               
            var tempArray = new T[Array.Length+1];
            for(int i = 0; i < Array.Length; i++)
                tempArray[i] = Array[i];

            tempArray[tempArray.Length-1] = key;

            Array = tempArray;

            return this;
        }

        public SimpleArray<T> Remove(T key)
        {
            if (Array is null)
                return this;

            var tempArray = new T[Array.Length - 1];
            for (int i = 0, j = 0; i < Array.Length; i++, j++) 
            {
                if (j == Array.Length - 1) 
                    return this;

                if (Array[i].Equals(key))
                    j--;
                else
                    tempArray[j] = Array[i];
            }

            Array = tempArray;

            return this;
        }

        public SimpleArray<T> RemoveAt(T index)
        {
            //TODO: implement this

            return this;
        }

        public void Traverse()
        {
            for (int i = 0; i < Array.Length - 1; i++)
                Console.Write(Array[i] + " ");
            Console.WriteLine(Array[Array.Length - 1]);
        }
    }
}
