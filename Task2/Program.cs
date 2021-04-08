using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input a:");
            string inputA = Console.ReadLine();
            Console.WriteLine("input b:");
            string inputB = Console.ReadLine();

            int sum = int.Parse(inputA) + int.Parse(inputB); //parsed strings to int and then added them
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
