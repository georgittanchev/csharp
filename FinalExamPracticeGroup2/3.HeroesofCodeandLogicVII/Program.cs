using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _3.HeroesofCodeandLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfHeroes = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> partyOfHeroes = new Dictionary<string, List<int>>();
            for (int i = 0; i < numberOfHeroes; i++)
            {
                string[] heroesCommand = Console.ReadLine().Split();
                string heroName = heroesCommand[0];
                int hp = int.Parse(heroesCommand[1]);
                int mp = int.Parse(heroesCommand[2]);
                if (!partyOfHeroes.ContainsKey(heroName))
                {
                    partyOfHeroes.Add(heroName, new List<int> { hp, mp });
                }
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] splittedCommand = command.Split(" - ");
                string theCommand = splittedCommand[0];
                string heroName = splittedCommand[1];
                if (theCommand.Contains("CastSpell"))
                {
                    int mpNeeded = int.Parse(splittedCommand[2]);
                    string spellName = splittedCommand[3];
                    int result = partyOfHeroes[heroName][1] - mpNeeded;
                    if (result < 0)
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }

                    else
                    {
                        partyOfHeroes[heroName][1] -= mpNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {partyOfHeroes[heroName][1]} MP!");
                    }
                }

                else if (theCommand.Contains("TakeDamage"))
                {
                    int damage = int.Parse(splittedCommand[2]);
                    string attacker = splittedCommand[3];
                    partyOfHeroes[heroName][0] -= damage;
                    if (partyOfHeroes[heroName][0] > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {partyOfHeroes[heroName][0]} HP left!");
                    }

                    else
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        partyOfHeroes.Remove(heroName);
                    }
                }

                else if (theCommand.Contains("Recharge"))
                {
                    int amountToRecharge = int.Parse(splittedCommand[2]);
                    if (partyOfHeroes[heroName][1] + amountToRecharge > 200)
                    {
                        int difference =  partyOfHeroes[heroName][1] - 200;
                        amountToRecharge = Math.Abs(difference);
                        partyOfHeroes[heroName][1] += amountToRecharge;
                    }
                    else
                    {
                        partyOfHeroes[heroName][1] += amountToRecharge;
                    }

                    Console.WriteLine($"{heroName} recharged for {amountToRecharge} MP!");
                }

                else if (theCommand.Contains("Heal"))
                {
                    int amountToHeal = int.Parse(splittedCommand[2]);
                    if (partyOfHeroes[heroName][0] + amountToHeal > 100)
                    {
                        int difference = partyOfHeroes[heroName][0] - 100;
                        amountToHeal = Math.Abs(difference);
                        partyOfHeroes[heroName][0] += amountToHeal;
                    }
                    else
                    {
                        partyOfHeroes[heroName][0] += amountToHeal;
                    }

                    Console.WriteLine($"{heroName} healed for {amountToHeal} HP!");

                }
            }

            partyOfHeroes = partyOfHeroes.OrderByDescending(hp => hp.Value[0]).ThenBy(name => name.Key).ToDictionary(name => name.Key, hp => hp.Value);
            foreach (var item in partyOfHeroes)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine($" HP: {item.Value[0]}");
                Console.WriteLine($" MP: {item.Value[1]}");
            }

            
        }
    }
}
