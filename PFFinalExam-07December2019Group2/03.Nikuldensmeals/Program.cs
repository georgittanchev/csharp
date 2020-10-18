using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.Nikuldensmeals
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, List<string>> meals = new Dictionary<string, List<string>>();
            int countOfUnlikedMeals = 0;
            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] splittedInput = input.Split("-");
                string command = splittedInput[0];
                string guestName = splittedInput[1];
                string guestMeal = splittedInput[2];
                if (command == "Like")
                {
                    if (!meals.ContainsKey(guestName))
                    {
                        meals.Add(guestName, new List<string>());
                        meals[guestName].Add(guestMeal);
                    }
                    else if (!meals[guestName].Contains(guestMeal))
                    {
                        meals[guestName].Add(guestMeal);
                    }
                }
                else if (command == "Unlike")
                {
                    if (!meals.ContainsKey(guestName))
                    {
                        Console.WriteLine($"{guestName} is not at the party.");
                    }
                    else if (!meals[guestName].Contains(guestMeal))
                    {
                        Console.WriteLine($"{guestName} doesn't have the {guestMeal} in his/her collection.");
                    }
                    else if (meals[guestName].Contains(guestMeal) && meals.ContainsKey(guestName))
                    {
                        Console.WriteLine($"{guestName} doesn't like the {guestMeal}.");
                        meals[guestName].Remove(guestMeal);
                        countOfUnlikedMeals++;
                    }
                }
            }

            meals = meals.OrderByDescending(y => y.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
            foreach (var item in meals)
            {
                Console.WriteLine($"{item.Key}: {string.Join(", ", item.Value)}");
            }
            Console.WriteLine($"Unliked meals: {countOfUnlikedMeals}");
        }
    }
}
