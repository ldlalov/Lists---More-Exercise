using System;
using System.Collections.Generic;
using System.Linq;


namespace _05._Drum_Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> drums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string command = "";
            List<int> drumsAsNew = drums.ToList();
            while ((command = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(command);
                for (int i = 0;i<drums.Count;i++)
                {
                    drums[i] -= hitPower;
                    if (drums[i] <= 0)
                    {
                        if (savings>= drumsAsNew[i] * 3)
                        {
                            drums[i] = drumsAsNew[i];
                            savings -= drumsAsNew[i] * 3;
                        }
                        else
                        {
                            drums.RemoveAt(i);
                            drumsAsNew.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
            Console.WriteLine(String.Join(' ', drums));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
