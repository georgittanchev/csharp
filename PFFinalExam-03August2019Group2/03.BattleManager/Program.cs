using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _03.BattleManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int[]> battle = new Dictionary<string, int[]>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Results")
            {
                string[] splittedInput = input.Split(":");
                string command = splittedInput[0];
                if (command == "Add")
                {
                    string personName = splittedInput[1];
                    int health = int.Parse(splittedInput[2]);
                    int energy = int.Parse(splittedInput[3]);
                    if (!battle.ContainsKey(personName))
                    {
                        battle.Add(personName, new int[2] {health, energy});
                    }
                    else
                    {
                        battle[personName][0] += health;
                    }
                }
                else if (command == "Attack")
                {
                    string attackerName = splittedInput[1];
                    string defenderName = splittedInput[2];
                    int damage = int.Parse(splittedInput[3]);
                    if (battle.ContainsKey(attackerName) && battle.ContainsKey(defenderName) && battle[defenderName][0] > 0 && battle[attackerName][1] > 0)
                    {
                        battle[defenderName][0] -= damage;
                        battle[attackerName][1] -= 1;
                        if (battle[defenderName][0] <= 0)
                        {
                            battle.Remove(defenderName);
                            Console.WriteLine($"{defenderName} was disqualified!");
                        }
                        if (battle[attackerName][1] <= 0)
                        {
                            battle.Remove(attackerName);
                            Console.WriteLine($"{attackerName} was disqualified!");
                        }
                    }
                }
                else if (command == "Delete")
                {
                    string userName = splittedInput[1];
                    if (battle.ContainsKey(userName))
                    {
                        battle.Remove(userName);
                    }
                    else if (splittedInput[1] == "All")
                    {
                        battle.Clear();
                    }
                }

            }

            battle = battle.OrderByDescending(x => x.Value[0]).ThenBy(p => p.Key).ToDictionary(p => p.Key, x => x.Value);
            Console.WriteLine($"People count: {battle.Keys.Count}");
            foreach (var item in battle)
            {
                Console.WriteLine($"{item.Key} - {item.Value[0]} - {item.Value[1]}");
            }
        }
    }
}
