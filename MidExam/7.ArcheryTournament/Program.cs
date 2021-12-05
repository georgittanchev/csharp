using System;
using System.Linq;
using System.Collections.Generic;

namespace _7.ArcheryTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split("|").Select(int.Parse).ToList();
            int iskrenPoints = 0;
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Game over")
            {
                // "Shoot Left@{start index}@{length}":

                string[] input = command.Split("@");
                string order = input[0];
                int index = int.Parse(input[1]);
                int lenght = int.Parse(input[2]);

                if (order == "Shoot Left")
                {
                    if (index >= 0 && index < targets.Count)
                    {
                        int sum = index - lenght;
                        if (sum < 0)
                        {
                            for (int i = targets.Count -1; i > lenght; i--)
                            {
                                targets[i] = targets[i] - 5;
                                iskrenPoints += 5;
                            }
                        }
                    
                    }
                }

            }
            Console.WriteLine(string.Join(" ", targets));
            







        }
    }
}
