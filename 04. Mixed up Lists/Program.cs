using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Mixed_up_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> result = new List<int>();
            List<int> firstList = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            secondList.Reverse();
            List<int> range = new List<int>();
            int shorterList = 0;
            if (firstList.Count < secondList.Count)
            {
                shorterList = firstList.Count;
                for (int i = 2; i >= 1; i--)
                {
                    range.Add(secondList.Last());
                    secondList.RemoveAt(secondList.Count - 1);
                }

            }
            else
            {
                shorterList = secondList.Count;
                for (int i = 2; i >= 1; i--)
                {
                    range.Add(firstList.Last());
                    firstList.RemoveAt(firstList.Count-1);
                }
            }
            range.Sort();
            for (int i = 0; i < shorterList; i++)
            {
                if (firstList[i]>range[0] && firstList[i]<range[1])
                {
                result.Add(firstList[i]);
                }
                if (secondList[i]>range[0] && secondList[i]<range[1])
                {
                    result.Add(secondList[i]);
                }
            }
            result.Sort();
            Console.WriteLine(string.Join(' ',result));
        }
    }
}
