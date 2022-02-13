using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Car_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] times = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            double firstTime = 0;
            double secondTime = 0;
            for (int i = 0; i < times.Length / 2; i++)
            {
                if (times[i] == 0)
                {
                    firstTime *= 0.8;
                }
                    firstTime += times[i];

            }
            for (int i = times.Length-1; i > times.Length / 2; i--)
            {
                if (times[i] == 0)
                {
                    secondTime *= 0.8;
                }
                    secondTime += times[i];
            }
            if (firstTime<secondTime)
                {
                    Console.WriteLine($"The winner is left with total time: { Math.Round(firstTime,1)}");
                }
                else
                {
                    Console.WriteLine($"The winner is right with total time: { Math.Round(secondTime,1)}");
                }
            
        }
    }
}