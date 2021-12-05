using System;
using System.Linq;
using System.Collections.Generic;

namespace _9.Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(", ").ToList();
            List<string> inventory = new List<string>();
            inventory = items;
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Craft!")
            {
                List<string> commands = command.Split(" - ").ToList();
                string order = commands[0];
                string item = commands[1];
                if (order == "Collect")
                {
                    if (!inventory.Contains(item))
                    {
                        inventory.Add(item);
                    }
                }
                else if (order == "Drop")
                {
                    if (inventory.Contains(item))
                    {
                        inventory.Remove(item);
                    }
                }
                else if (order == "Combine Items")
                {
                    string[] differentItems = commands[1].Split(":").ToArray();
                    string oldItem = differentItems[0];
                    string newItem = differentItems[1];
                    if (inventory.Contains(oldItem))
                    {
                       int index =  inventory.IndexOf(oldItem);
                        inventory.Insert(index + 1, newItem);
                    }
                }
                else if (order == "Renew")
                {
                    if (inventory.Contains(item))
                    {
                        inventory.Remove(item);
                        inventory.Add(item);
                    }
                }

            }

            Console.WriteLine(string.Join(", ", inventory));

        }
    }
}
