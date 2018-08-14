using System;
using System.Collections;
using System.Collections.Generic;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }
                else if (input[i] == ')')
                {
                    var startIndexes = stack.Pop();
                    var lenght = i - startIndexes+1;
                    var result = input.Substring(startIndexes, lenght);
                    Console.WriteLine(result);
                }
            }
        }
    }
}
