using System;
using System.Collections;
using System.Collections.Generic;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stack = new Stack<char>();

            foreach (char ch in input)
            {
                stack.Push(ch);
            }
            for (int i = stack.Count - 1; i >= 0; i--)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
    }
}
