using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            int lenght = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int[] dna = new int[lenght];
            string s = string.Empty;
            while (command != "Clone them!")
            {
                int[] currentDNA = command.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int i = 0; i < currentDNA.Length; i++)
                {
                    for (int k = i+1; k < currentDNA.Length; k++)
                    {
                        s += currentDNA[i];

                    }


                }
            }







        }
    }
}
