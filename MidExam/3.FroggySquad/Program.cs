using System;
using System.Linq;
using System.Collections.Generic;

namespace _3.FroggySquad
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> firstFrogs = Console.ReadLine().Split().ToList();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Print")
            {
                string[] commandString = command.Split();
                if (commandString[0] == "Join")
                {
                    string name = commandString[1];
                    firstFrogs.Add(name);
                }
                if (commandString[0] == "Jump")
                {
                    string name = commandString[1];
                    int index = int.Parse(commandString[2]);
                    if (index >= 0 && index <= firstFrogs.Count)
                    {
                        firstFrogs.Insert(index, name);
                    }
                }
                if (commandString[0] == "Dive")
                {
                    int index = int.Parse(commandString[1]);
                    if (index >= 0 && index <= firstFrogs.Count)
                    {
                        firstFrogs.RemoveAt(index);
                    }
                }
                if (commandString[0] == "First")
                {
                    int count = int.Parse(commandString[1]);
                    if (count >= firstFrogs.Count)
                    {
                        Console.WriteLine(string.Join(" ", firstFrogs));
                    }
                    else
                    {
                        List<string> frogsCount = new List<string>();
                        for (int i = 0; i < count; i++)
                        {
                            frogsCount.Add(firstFrogs[i]);
                        }
                        Console.WriteLine(string.Join(" ", frogsCount));
                    }
                }
                if (commandString[0] == "Last")
                {
                    int count = int.Parse(commandString[1]);
                   
                    if (count >= firstFrogs.Count)
                    {
                        Console.WriteLine(string.Join(" ", firstFrogs));
                    }
                    else
                    {
                        List<string> frogsCountLast = new List<string>();
                        int startingCount = firstFrogs.Count - count;
                        for (int i = startingCount; i < firstFrogs.Count; i++)
                        {
                            frogsCountLast.Add(firstFrogs[i]);
                        }
                        Console.WriteLine(string.Join(" ", frogsCountLast));
                    }
                }
                if (commandString[0] == "Print")
                {
                    string way = commandString[1];
                    if (way == "Normal")
                    {
                        Console.Write("Frogs: "); Console.Write(string.Join(" ", firstFrogs));
                        Console.WriteLine();
                        break;
                    }
                    if (way == "Reversed")
                    {
                        firstFrogs.Reverse();
                        Console.Write("Frogs: "); Console.Write(string.Join(" ", firstFrogs));
                        Console.WriteLine();
                        break;

                    }
                }


            }



        }
    }
}
