using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("hello world");
            Console.Write("What is your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}, it's nice to meet you.");
            Console.ReadKey();
        }
    }
}
