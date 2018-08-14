using System;
using System.Collections.Generic;

namespace DecimalToBinaryConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var binary = new Stack<string>();

            if (number == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                while (number > 0)
                {
                    var temp = number % 2;
                    binary.Push(temp.ToString());
                    number /= 2;
                }
                while (binary.Count > 0)
                {
                    Console.Write(binary.Pop());
                }
                Console.WriteLine();
            }
        }
    }
}
