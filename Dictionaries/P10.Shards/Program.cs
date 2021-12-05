using System;
using System.Linq;
using System.Collections.Generic;

namespace P10.Shards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> perfectItems = new Dictionary<string, int>();
            Dictionary<string, int> suckItems = new Dictionary<string, int>();
            List<string> command = new List<string>();
            bool hasPerfectItem = false;
            string item = string.Empty;
            int quantity = 0;
            perfectItems["shards"] = 0;
            perfectItems["fragments"] = 0;
            perfectItems["motes"] = 0;
            string legendary = string.Empty;

            while (hasPerfectItem != true)
            {
                command = Console.ReadLine().ToLower().Split().ToList();
                for (int i = 0; i < command.Count; i+=2)
                {
                    item = command[i + 1];
                    quantity = int.Parse(command[i]);

                    if (perfectItems.ContainsKey(item))
                    {
                        perfectItems[item] += quantity;
                        if (perfectItems[item] >= 250)
                        {
                            perfectItems[item] -= 250;
                            if (item == "shards")
                            {
                                legendary = "Shadowmourne";
                            }
                            else if (item == "motes")
                            {
                                legendary = "Dragonwrath";
                            }
                            else if (item == "fragments")
                            {
                                legendary = "Valanyr";
                            }
                            hasPerfectItem = true;
                            break;
                        }
                    }

                    else
                    {
                        if (!suckItems.ContainsKey(item))
                        {
                            suckItems.Add(item, quantity);
                        }
                        else
                        {
                            suckItems[item] += quantity;
                        }
                    }
                   

                }

            }

            Console.WriteLine($"{legendary} obtained!");
            perfectItems = perfectItems
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(a => a.Key, b => b.Value);
            foreach (var kvp in perfectItems)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            suckItems = suckItems.OrderBy(x => x.Key).ToDictionary(a => a.Key, b=> b.Value);
            foreach (var kvp in suckItems)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }


        }
    }
}
