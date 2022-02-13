using System;
using System.Collections.Generic;
using System.Linq;


namespace _03._Take_Skip_Rope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] text = Console.ReadLine().ToCharArray();
            List<string> result = new List<string>();
            List<int> numbers = new List<int>();
            List<int> takeList = new List<int>();
            List<int> skypeList = new List<int>();
            List<string> nonNumbers = new List<string>();
            for (int i = 0; i < text.Length; i++)
            {
                bool isDigit = "0123456789".IndexOf(text[i])>=0;
                
                if (isDigit)
                {
                    numbers.Add(int.Parse(text[i].ToString()));
                }
                else
                {
                    nonNumbers.Add(text[i].ToString());
                }
            }
            takeList.Add(numbers[0]);
            skypeList.Add(numbers[1]);
            for (int i = 2; i < numbers.Count; i++)
            {
                if (i%2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skypeList.Add(numbers[i]);
                }
            }
            int position = 0;
            for (int i = 0; i < skypeList.Count; i++)
            {
                for (int j = position; j < position + takeList[i]; j++)
                {
                    if (j <= nonNumbers.Count-1)
                    {
                    result.Add(nonNumbers[j]);
                    }
                }
                position += (takeList[i]+skypeList[i]);
            }
            Console.WriteLine(String.Join("",result));
        }
    }
}
