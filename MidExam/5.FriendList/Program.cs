using System;
using System.Linq;
using System.Collections.Generic;

namespace _5.FriendList
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> friends = Console.ReadLine().Split(", ").ToList();
            string report = string.Empty;
            int blacklistedCounter = 0;
            int lostCounter = 0;
            while ((report = Console.ReadLine()) != "Report")
            {
                string[] input = report.Split();
                string command = input[0];
                if (command == "Blacklist")
                {
                    string name = input[1];
                    if (friends.Contains(name))
                    {
                        int nameIndex = friends.IndexOf(name);
                        friends.RemoveAt(nameIndex);
                        friends.Insert(nameIndex, "Blacklisted");
                        Console.WriteLine($"{name} was blacklisted.");
                        blacklistedCounter++;
                    }
                    else
                    {
                        Console.WriteLine($"{name} was not found.");
                    }
                }
                if (command == "Error")
                {
                    int index = int.Parse(input[1]);
                    string name = friends[index];
                    if (name != "Blacklisted" && name!="Lost")
                    {
                        friends.RemoveAt(index);
                        friends.Insert(index, "Lost");
                        Console.WriteLine($"{name} was lost due to an error.");
                        lostCounter++;
                    }
                }
                if (command == "Change")
                {
                    int index = int.Parse(input[1]);
                    string name = input[2];
                    if (index >= 0 && index < friends.Count)
                    {
                        string oldName = friends[index];
                        friends.RemoveAt(index);
                        friends.Insert(index, name);
                        Console.WriteLine($"{oldName} changed his username to {name}.");
                    }
                }

            }
            Console.WriteLine($"Blacklisted names: {blacklistedCounter}");
            Console.WriteLine($"Lost names: {lostCounter}");
            Console.WriteLine(string.Join(" ", friends));


        }
    }
}
