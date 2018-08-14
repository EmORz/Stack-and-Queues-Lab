using System;
using System.Collections;
using System.Collections.Generic;

namespace TrafficLight
{
    class Program
    {
        static void Main(string[] args)
        {
            var numCars = int.Parse(Console.ReadLine());
            var queues = new Queue<string>();
            var commands = Console.ReadLine();
            var counter = 0;
            while (commands != "end")
            {
                if (commands == "green")
                {                   
                    for (int i = 0; i < numCars; i++)
                    {
                       
                        if (queues.Count>0)
                        {
                            counter++;
                            Console.WriteLine(queues.Dequeue() + " passed!");
                        }
                        continue;
                    }                    
                }
                else
                {
                    queues.Enqueue(commands);
                }
                commands = Console.ReadLine();
            }
            Console.WriteLine(counter+" cars passed the crossroads.");
        }
    }
}
