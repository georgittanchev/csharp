using System;
using System.Linq;
using System.Collections.Generic;

namespace _5.TanksCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ownedTanks = Console.ReadLine().Split(", ").ToList();
            int numberOfLinesToRead = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfLinesToRead; i++)
            {
                string[] input = Console.ReadLine().Split(", ").ToArray();
                string command = input[0];
                if (command == "Add")
                {
                    string tankName = input[1];
                    if (!ownedTanks.Contains(tankName))
                    {
                        ownedTanks.Add(tankName);
                        Console.WriteLine($"Tank successfully bought");
                    }
                    else
                    {
                        Console.WriteLine("Tank is already bought");
                    }
                }
                if (command == "Remove")
                {
                    string tankName = input[1];
                   
                    if (ownedTanks.Contains(tankName))
                    {
                        ownedTanks.Remove(tankName);
                        Console.WriteLine("Tank successfully sold");
                        
                    }
                    else
                    {
                        Console.WriteLine($"Tank not found");
                    }
                }
                if (command == "Remove At")
                {
                    int index = int.Parse(input[1]);
                    if (index >= 0 && index < ownedTanks.Count)
                    {
                        ownedTanks.RemoveAt(index);
                        Console.WriteLine("Tank successfully sold");
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
                if (command == "Insert")
                {
                    int index = int.Parse(input[1]);
                    string tankName = input[2];
                    if (index >= 0 && index < ownedTanks.Count)
                    {
                        if (!ownedTanks.Contains(tankName))
                        {
                            ownedTanks.Insert(index, tankName);
                            Console.WriteLine("Tank successfully bought");
                        }
                        else
                        {
                            Console.WriteLine("Tank is already bought");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
            }
            Console.Write(string.Join(", ", ownedTanks));
        }
    }
}
