using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
            
            CustomList<int> apple = new CustomList<int>() { 5, 6, 8, 12 };




            apple.Add(4);
            apple.Add(5);
            apple.Print();
            Console.ReadLine();
            int test = apple.Count;
            CustomList<string> banana = new CustomList<string>();
            banana.Add("dog");
            banana.Add("cat");
            banana.Print();
            Console.ReadLine();
            banana.Remove("dog");
            banana.Print();
            Console.ReadLine();

            foreach (int i in apple)
            {
                Console.WriteLine(i);
                Console.ReadLine();
            }
            CustomList<int> num1 = new CustomList<int>();
            CustomList<int> num2 = new CustomList<int>();
            num1.Add(6);
            num1.Add(2);
            num1.Add(4);
            num1.Add(3);
            num2.Add(5);
            num2.Add(1);
            num2.Add(7);
            num2.Add(8);
            CustomList<int> num3 = new CustomList<int>();
            num1.Print();
            Console.ReadLine();
            num2.Print();
            Console.ReadLine();
            num3 = num1 + num2;
            num3.Print();
            Console.ReadLine();

            CustomList<int> num4 = new CustomList<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            CustomList<int> num5 = new CustomList<int>() { 5, 6, 7, 8, 9, 10, 11 };

            num4 = num4 - num5;
            num4.Print();
            Console.ReadLine();

            CustomList<string> animals1 = new CustomList<string>() { "dog", "cat", "dog", "mouse", "moose", "cat" };
            CustomList<string> animals2 = new CustomList<string>() { "dog", "cat", "elephant", "banana" };


            animals1 = animals1 - animals2;
            animals1.Print();
            Console.ReadLine();

           
            Console.WriteLine(num1.ToString());
            Console.ReadLine();

            var numbersAndWords = num2.Zip(num1, (first, second) => first );
            foreach(var i in numbersAndWords)
            {
                Console.WriteLine(i);
                Console.ReadLine();
            }

            num5.ToString();
            num5.Print();
            Console.ReadLine();
                
            Console.ReadLine();

            num1.BubbleSort(num1);
            num1.Print();
            Console.ReadLine();

            CustomList<double> doubles = new CustomList<double>() { 1.1, 3.3, 2.2, 5.5, 4.4 };
            doubles.BubbleSort(doubles);
            doubles.Print();
            Console.ReadLine();

        }
    }
}
