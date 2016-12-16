using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable
    {
        T value;
        public int count = 0;
        public T[] customArray;
        public CustomList()
        {
            customArray = new T[0];
        }
        public void Add(T addToArray)
        {
            if (customArray.Count() >= 0)
            value = addToArray;
            T[] array = new T[customArray.Length + 1];
            for (int i = 0; i < customArray.Length; i++)
            {
                array[i] = customArray[i];
            }
            array[customArray.Length] = value;
            customArray = array;
        }
        public void Print()
        {
            foreach (T i in customArray)
            {
                Console.WriteLine(i);
            }
        }
        public bool Remove(T removeFromArray)
        {
            if (customArray.Count() > 0)
            {
                value = removeFromArray;
                T[] array = new T[customArray.Length - 1];
                int j = 0;
                for (int i = 0; i < customArray.Count(); i++)
                {
                    if (customArray[i].Equals(value) && j == 0)
                    {
                        j++;
                    }
                    else
                    {
                        array[i - j] = customArray[i];
                    }
                }
                customArray = array;
                return true;
            }
            else
            {
                return false;
            }
        }
        public int Count
        {
            get
            {
                if (customArray != null)
                {
                    for (int i = 0; i < customArray.Length; i++)
                    {
                        count++;
                    }
                    return count;
                }
                else
                {
                    return 0;
                }
            }
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < customArray.Length; i++)
            {
                yield return customArray[i];
            }
        }
        public static CustomList<T> operator +(CustomList<T> one, CustomList<T> two)
        {
            T[] array = new T[one.customArray.Length + two.customArray.Length];
            for (int i = 0; i < one.customArray.Length; i++)
                if (one.customArray.Length > 0)
                {
                    array[i] = one.customArray[i];
                }
            for (int i = one.customArray.Length; i < (one.customArray.Length + two.customArray.Length); i++)
                if ((one.customArray.Length + two.customArray.Length) > one.customArray.Length)
                {
                    array[i] = two.customArray[i - one.customArray.Length];
                }
            one.customArray = array;
            return one;
        }
        public static CustomList<T> operator -(CustomList<T> one, CustomList<T> two)
        {
            int j = 0;
            T[] array = new T[one.customArray.Length];
            for (int i = 0; i < one.customArray.Length; i++)
                for (int k = 0; k < two.customArray.Length; k++)
                    if (one.customArray[i].Equals(two.customArray[k]))
                    {
                        j++;
                        k = two.customArray.Length;
                    }
                    else
                    {
                        if (i != one.customArray.Length)
                        {
                            array[i - j] = one.customArray[i];
                        }
                    }
            T[] arrayTwo = new T[one.customArray.Length - j];
            for (int l = 0; l < array.Length; l++)
                if (array[l] != null && (arrayTwo.Length > l))
                {
                    arrayTwo[l] = array[l];
                }
            one.customArray = arrayTwo;
            return one;
        }
        public CustomList<T> Zip(CustomList<T> one, Func<T, T, T> func1)
        {
            int l = customArray.Length > one.customArray.Length ? l = (one.customArray.Length * 2) : l = (customArray.Length * 2);
            CustomList<T> temporaryList = new CustomList<T>();
            T[] array = new T[l];
            temporaryList.customArray = array;
            T temporaryListContent;
            int k = 0;
            int j = 1;
            for (int i = 0; i < customArray.Length; i++)
                if (customArray.Length > i && one.customArray.Length >i)
                {
                    temporaryListContent = customArray[i];
                    temporaryList.customArray[i + k] = temporaryListContent;
                    k++;
                    temporaryListContent = one.customArray[i];
                    temporaryList.customArray[i + j] = temporaryListContent;
                    j++;
                }
            return temporaryList;
        }
        public override string ToString()
        {
            string converted = "";
            foreach (T i in customArray)
            {
                converted += i;
            }
            return converted;
        }
        public static void exchange(CustomList<T> one, int m, int n)
        {
            T temporary = one.customArray[m];
            one.customArray[m] = one.customArray[n];
            one.customArray[n] = temporary;
        }

        // This is a bubble sort algorithm that will sort a lit of data in order of value
        // from lowest to highest. It will not work on strings. it is also partially relient 
        // on the 'exchange' function above ^ 
        public void BubbleSort(CustomList<T> one)
        {
            int i, j;
            int N = one.customArray.Length;
            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (Comparer<T>.Default.Compare(one.customArray[i], one.customArray[i + 1]) > 0)
                        exchange(one, i, i + 1);
                }
            }
        }

    }
}
