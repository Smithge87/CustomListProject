using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        T value;
        T[] blues = new T[0];


        public void Add(T addToArray)
        {
            value = addToArray;
            Array.Resize(ref blues, blues.Length + 1);
            blues[blues.Length - 1] = value;
        }
        public void Print()
        {
            foreach (T i in blues)
            {
                Console.WriteLine(i);
            }

        }
        public void Remove(T removeFromArray)
        {
            value = removeFromArray;
            Array.Resize(ref blues, blues.Length - 1);
            blues[blues.Length + 1] = value;
        }
    }
    
}
