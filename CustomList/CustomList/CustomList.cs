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
        //public int capacity;
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
            for  (int i =0; i < customArray.Length; i++)
            {
                array[i] = customArray[i];
            }
            array[customArray.Length] = value;
            T[] arrayTemp = new T[customArray.Length + 1];
            customArray = arrayTemp;
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
                int j= 0;
                for (int i = 0; i < customArray.Count(); i++)
                {
                    if (customArray[i].Equals(value) && j==0)
                    {
                        j++;
                    }
                    else
                    {
                        array[i-j] = customArray[i];
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
                int count = (customArray.Length) + 1;
                return count;
            }
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < customArray.Length; i++)
            {
                yield return customArray[i];
            }
        }
        public static CustomList<T> operator+ (CustomList<T> one , CustomList<T> two)
        {
            T[] array = new T[one.customArray.Length + two.customArray.Length];
            for (int i = 0; i < one.customArray.Length; i++)
                if (one.customArray.Length > 0) 
                {
                    array[i] = one.customArray[i];
                }
            for (int i = one.customArray.Length; i < (one.customArray.Length+two.customArray.Length);i++ )
                if ((one.customArray.Length+two.customArray.Length) > one.customArray.Length)
                {
                    array[i] = two.customArray[i-one.customArray.Length];
                }
            one.customArray = array;
            return one;
        }
        public static CustomList<T> operator- (CustomList<T> one , CustomList<T> two )
        {
            int j = 0;
            T[] array = new T[one.customArray.Length];
            foreach (int i =0; i < one.customArray.Length; i++)
                if(one.customArray[i].Equals(two.customArray[i]))
                {
                    j++;
                }
                else
                {
                    array[i-j] = one.customArray[i];
                }
        }


        //public int Capacity { get; set; }
        //DONE    public int Count { get; }
        //DONE    public CustomList();
        //DONE    public void Add(T item);
        //public void Insert(int index, T item);
        //DONE    public bool Remove(T item);
        //public static SuperList<T> operator -(SuperList<T> list1, SuperList<T> list2);
        //DONE    public static SuperList<T> operator +(SuperList<T> list1, SuperList<T> list2);
        //DONE    public IEnumerator<T> GetEnumerator();
        //IEnumerator IEnumerable.GetEnumerator();

        //        The built-in List<T> class is a generic class that acts as a wrapper over the array class. You cannot use built-in List or Array methods.
        //(10 points): As a developer, I want to use a custom-built list class that stores its values in an array, so that I can store any data type in my collection.
        //(10 points): As a developer, I want the ability to add an object to an instance of my custom-built list class.
        //(10 points): As a developer, I want the ability to remove an object from an instance of my custom-built list class.
        //(10 points): As a developer, I want the custom list class to be iterable.
        //(10 points): As a developer, I want to be able to override the ToString method that converts the contents of the custom list to a string.
        //(10 points): As a developer, I want to be able to overload the + operator, so that I can add two instances of the custom list class together.
        //(10 points): As a developer, I want to be able to overload the – operator, so that I can subtract one instance of a custom list class from another instance of a custom list class.
        //(10 points): As a developer, I want a Count property implemented on the custom-built list class, so that I can get a count of the number of elements in my custom list class instance.
        //(10 points): As a developer, I want the ability to Enumerable.Zip() two custom list class instances together.
        //(10 points): As a developer, I want to use C# best practices, SOLID design principles, and good naming conventions on the project. 
        //(20 points (2 points each)): As a developer, I want to create 10 unit tests for my project, so that I can ensure the functionality is working properly.
        //(Bonus 5 points): As a developer, I want the ability to sort an instance of my custom-built list class. To be eligible for the bonus points, you may not use Array.Sort() that is already built in and you must tell us what sorting algorithm you used.
    }


}
