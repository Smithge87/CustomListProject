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
            CustomList<int> apple = new CustomList<int>();
            apple.Add(4);
            apple.Add(5);
            apple.Print();
            Console.ReadLine();
            apple.Remove(5);
            apple.Print();
            Console.ReadLine();
        }
    }
}
