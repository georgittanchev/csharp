using System;
using System.Linq;
using System.Collections.Generic;

namespace _9.MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {

            int health = 100;
            double bitcoins = 0;
            List<string> commands = new List<string>();
            while (health > 0)
            {
                commands = Console.ReadLine().Split("|").ToList();
                for (int i = 0; i < commands.Count; i++)
                {
                    string[] separatedCommands = commands[i].Split();
                    string order = separatedCommands[0];
                    int number = int.Parse(separatedCommands[1]);
                    if (order == "potion")
                    {
                        if (health < 100)
                        {
                            int healthNeeded = 100 - health;
                            if (number > healthNeeded)
                            {
                                health += healthNeeded;
                                Console.WriteLine($"You healed for {healthNeeded} hp.");
                                Console.WriteLine($"Current health: {health} hp.");
                            }
                            else
                            {
                                health += number;
                                Console.WriteLine($"You healed for {number} hp.");
                                Console.WriteLine($"Current health: {health} hp.");
                            }
                        }
                    }
                    else if (order == "chest")
                    {
                        bitcoins += number;
                        Console.WriteLine($"You found {number} bitcoins.");
                    }
                    if (order != "chest" && order != "potion")
                    {
                        health -= number;
                    }
                    if (health <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {order}.");
                        Console.WriteLine($"Best room: {(i+1)}");
                        break;
                    }
                    else if (health > 0 && order != "potion" && order != "chest")
                    {
                        Console.WriteLine($"You slayed {order}.");
                    }

                }

                if (health > 0)
                {
                    Console.WriteLine("You've made it!");
                    Console.WriteLine($"Bitcoins: {bitcoins}");
                    Console.WriteLine($"Health: {health}");
                    break;
                }
                

            }




        }
    }
}
