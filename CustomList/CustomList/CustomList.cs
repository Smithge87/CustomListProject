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
       public T[] blues = new T[0];


        public void Add(T addToArray)
        {
            value = addToArray;
            T[] array = new T[blues.Length + 1];
            array[1] = value;
            //T[] arrayTwo = array.Concat(blues);
            foreach (T i in blues)
            {
                array= i + blues[T];
            }
            //{
            //    array[i];
            //}

                //T[] arrayTwo = new T[blues.Length + array.Length];
                //blues.CopyTo(arrayTwo, 0);
                //array.CopyTo(arrayTwo, blues.Length);
                //blues = arrayTwo;


                //blues.CopyTo(array, 0);
                //value = addToArray;
                //T[] array2 = { addToArray };
                //T[] final = new T[blues.Length + array2.Length];
                //    final = new T[blues.Length + array2.Length];
                //    Buffer.BlockCopy(blues,
                //        0,
                //        final,
                //        0,
                //        blues.Length * sizeof(int));
                //    Buffer.BlockCopy(array2,
                //        0,
                //        final,
                //        blues.Length * sizeof(int),
                //        array2.Length * sizeof(int));
                //blues = final;
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
            blues[blues.Length - 1] = value;
            Array.Resize(ref blues, blues.Length - 1);
        }
    }
    
}
