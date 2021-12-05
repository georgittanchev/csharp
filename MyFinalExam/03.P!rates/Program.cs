using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace _03.P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, int[]> Towns = new Dictionary<string, int[]>();
            while ((input = Console.ReadLine()) != "Sail")
            {
                string[] splittedInput = input.Split("||");
                string townName = splittedInput[0];
                int people = int.Parse(splittedInput[1]);
                int gold = int.Parse(splittedInput[2]);
                if (!Towns.ContainsKey(townName))
                {
                    Towns.Add(townName, new int[2] {people, gold});
                }
                else
                {
                    Towns[townName][0] += people;
                    Towns[townName][1] += gold;
                } 
            }
            while ((input = Console.ReadLine()) != "End")
            {
                string[] splittedInput = input.Split("=>");
                string command = splittedInput[0];
                string townName = splittedInput[1];
                if (command == "Plunder")
                {
                    int people = int.Parse(splittedInput[2]);
                    int gold = int.Parse(splittedInput[3]);
                    Towns[townName][0] -= people;
                    Towns[townName][1] -= gold;
                    Console.WriteLine($"{townName} plundered! {gold} gold stolen, {people} citizens killed.");
                    if (Towns[townName][0] <= 0 || Towns[townName][1] <= 0)
                    {
                        Towns.Remove(townName);
                        Console.WriteLine($"{townName} has been wiped off the map!");
                    }
                    
                }
                else if (command == "Prosper")
                {
                    int gold = int.Parse(splittedInput[2]);
                    if (gold > 0)
                    {
                        Towns[townName][1] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {townName} now has {Towns[townName][1]} gold.");
                    }
                    else
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                    }
                }

            }

            if (Towns.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Towns = Towns.OrderByDescending(gold => gold.Value[1]).ThenBy(people => people.Key[0]).ToDictionary(people => people.Key, gold => gold.Value);
                Console.WriteLine($"Ahoy, Captain! There are {Towns.Count} wealthy settlements to go to:");
                foreach (var item in Towns)
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value[0]} citizens, Gold: {item.Value[1]} kg");
                }
            }
        }
    }
}
