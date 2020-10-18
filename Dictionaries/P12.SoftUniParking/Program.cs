using System;
using System.Linq;
using System.Collections.Generic;

namespace P12.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> carRegister = new Dictionary<string, string>();
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string command = input[0];
                string userName = input[1];
                if (command == "register")
                {
                    if (carRegister.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {carRegister[userName]}");
                    }
                    else
                    {
                        carRegister.Add(userName, input[2]);
                        Console.WriteLine($"{userName} registered {input[2]} successfully");
                    }
                }
                else if (command == "unregister")
                {
                    if (!carRegister.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        carRegister.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                    }

                }
  
            }
            foreach (var item in carRegister)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }

        }
    }
}
