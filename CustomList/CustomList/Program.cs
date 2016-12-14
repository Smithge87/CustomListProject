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
            CustomList<int> apple = new CustomList<int>() { 5,6,8,12 };
            apple.Add(4);
            apple.Add(5);
            apple.Print();
            Console.ReadLine();
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
                Console.WriteLine( i );
                Console.ReadLine();
            }
            CustomList<int> num1 = new CustomList<int>();
            CustomList<int> num2 = new CustomList<int>();
            num1.Add(1);
            num1.Add(2);
            num1.Add(3);
            num1.Add(4);
            num2.Add(5);
            num2.Add(6);
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
        }
    }
}
