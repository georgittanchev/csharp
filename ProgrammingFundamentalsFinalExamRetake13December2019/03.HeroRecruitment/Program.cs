using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _03.HeroRecruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> heroesAndSpells = new Dictionary<string, List<string>>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] splittedInput = input.Split();
                string command = splittedInput[0];
                string heroName = splittedInput[1];
                if (command == "Enroll")
                {
                    if (heroesAndSpells.ContainsKey(heroName))
                    {
                        Console.WriteLine($"{heroName} is already enrolled.");
                    }
                    else
                    {
                        heroesAndSpells.Add(heroName, new List<string>());
                    }
                }
                else if (command == "Learn")
                {
                    string spellName = splittedInput[2];
                    if (!(heroesAndSpells.ContainsKey(heroName)))
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                    else if (heroesAndSpells[heroName].Contains(spellName))
                    {
                        Console.WriteLine($"{heroName} has already learnt {spellName}.");
                    }
                    else if (heroesAndSpells.ContainsKey(heroName) && (!(heroesAndSpells[heroName].Contains(spellName))))
                    {
                        heroesAndSpells[heroName].Add(spellName);
                    }
                }
                else if (command == "Unlearn")
                {
                    string spellName = splittedInput[2];
                    if (!(heroesAndSpells.ContainsKey(heroName)))
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                    else if (!(heroesAndSpells[heroName].Contains(spellName)))
                    {
                        Console.WriteLine($"{heroName} doesn't know {spellName}.");
                    }
                    else if (heroesAndSpells.ContainsKey(heroName) && (heroesAndSpells[heroName].Contains(spellName)))
                    {
                        heroesAndSpells[heroName].Remove(spellName);
            
                    }

                }
            }

            heroesAndSpells = heroesAndSpells.OrderByDescending(x => x.Value.Count).ThenBy(d => d.Key).ToDictionary(x => x.Key, k => k.Value);
            Console.WriteLine("Heroes:");
            foreach (var hero in heroesAndSpells)
            {
                Console.WriteLine($"== {hero.Key}: {string.Join(", ", hero.Value)}");
            }
        }
    }
}
