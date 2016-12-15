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
            int l = 0;
            for (int i = 0; i < customArray.Length; i++)
                if ((customArray[i] != null) && (one.customArray[i] != null))
                {
                    l++; l++;
                }
            CustomList<T> temporaryList = new CustomList<T>();
            T[] array = new T[l];
            temporaryList.customArray = array;
            T temporaryListContent;
            int k = 0;
            int j = 1;
            for (int i = 0; i < customArray.Length; i++)
                if ((customArray[i] != null) && (one.customArray[i] != null))
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
        //public int Capacity { get; set; }
        //DONE    public int Count { get; }
        //DONE    public CustomList();
        //DONE    public void Add(T item);
        //public void Insert(int index, T item);
        //DONE    public bool Remove(T item);
        //DONE    public static SuperList<T> operator -(SuperList<T> list1, SuperList<T> list2);
        //DONE    public static SuperList<T> operator +(SuperList<T> list1, SuperList<T> list2);
        //DONE    public IEnumerator<T> GetEnumerator();
        //IEnumerator IEnumerable.GetEnumerator();

        //        The built-in List<T> class is a generic class that acts as a wrapper over the array class. You cannot use built-in List or Array methods.
        //DONE    TESTED    (10 points): As a developer, I want to use a custom-built list class that stores its values in an array, so that I can store any data type in my collection.
        //DONE    TESTED    (10 points): As a developer, I want the ability to add an object to an instance of my custom-built list class.
        //DONE    TESTED    (10 points): As a developer, I want the ability to remove an object from an instance of my custom-built list class.
        //DONE    (10 points): As a developer, I want the custom list class to be iterable.
        //DONE    (10 points): As a developer, I want to be able to override the ToString method that converts the contents of the custom list to a string.
        //DONE    TESTED    (10 points): As a developer, I want to be able to overload the + operator, so that I can add two instances of the custom list class together.
        //DONE    TESTED    (10 points): As a developer, I want to be able to overload the – operator, so that I can subtract one instance of a custom list class from another instance of a custom list class.
        //DONE    TESTED    (10 points): As a developer, I want a Count property implemented on the custom-built list class, so that I can get a count of the number of elements in my custom list class instance.
        //DONE    (10 points): As a developer, I want the ability to Enumerable.Zip() two custom list class instances together.
        //(10 points): As a developer, I want to use C# best practices, SOLID design principles, and good naming conventions on the project. 
        //(20 points (2 points each)): As a developer, I want to create 10 unit tests for my project, so that I can ensure the functionality is working properly.
    }
}
