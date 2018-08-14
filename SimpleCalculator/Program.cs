using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var stack = new Stack<string>(input.Reverse());

            while (stack.Count > 1)
            {
                int first = int.Parse(stack.Pop());
                var sing = stack.Pop();
                int second = int.Parse(stack.Pop());

                switch (sing)
                {
                    case "+": stack.Push((first + second).ToString());break;
                    case "-": stack.Push((first - second).ToString());break;
                }
            }
            Console.WriteLine(stack.Pop().ToString());
        }
    }
}
