using System;
using System.Collections;
using System.Collections.Generic;

namespace HotPatato
{
    class Program
    {
        static void Main(string[] args)
        {
            var chlidreArr = Console.ReadLine().Split();
            var num = int.Parse(Console.ReadLine());
            var queues = new Queue<string>(chlidreArr);
            while (queues.Count>1)
            {
                for (int i = 1; i < num; i++)
                {
                    queues.Enqueue(queues.Dequeue());
                }
                Console.WriteLine($"Removed {queues.Dequeue()}");
            }
            Console.WriteLine($"Last is {queues.Dequeue()}");
        }
    }
}
