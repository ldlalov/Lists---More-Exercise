using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> index= Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            char[] text = Console.ReadLine().ToCharArray();
            List<char> charList = text.ToList();
            string message = "";
            for (int i = 0; i < index.Count; i++)
            {
                int sumOfDigits = 0;
                int digits = index[i];
                while (digits >0)
                {
                    sumOfDigits += digits % 10;
                    digits = digits / 10;
                }
                if (sumOfDigits > charList.Count)
                {
                    sumOfDigits -= charList.Count;
                }
                message += charList[sumOfDigits];
                charList.RemoveAt(sumOfDigits);
            }
            Console.WriteLine(message);
        }
    }
}
