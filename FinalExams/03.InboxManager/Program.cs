using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.InboxManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> userEmailsDB = new Dictionary<string, List<string>>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] splitedInput = input.Split("->");
                if (splitedInput[0] == "Add")
                {
                    string userName = splitedInput[1];
                    if (userEmailsDB.ContainsKey(userName))
                    {
                        Console.WriteLine($"{userName} is already registered");
                    }
                    else
                    {
                        userEmailsDB.Add(userName, new List<string>());
                    }
                }
                else if (splitedInput[0] == "Send")
                {
                    string userName = splitedInput[1];
                    string email = splitedInput[2];
                    userEmailsDB[userName].Add(email);
                }
                else if (splitedInput[0] == "Delete")
                {
                    string userName = splitedInput[1];
                    if (!userEmailsDB.ContainsKey(userName))
                    {
                        Console.WriteLine($"{userName} not found!");
                    }
                    else
                    {
                        userEmailsDB.Remove(userName);
                    }
                }

            }


            userEmailsDB = userEmailsDB.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, k => k.Value);

            Console.WriteLine($"Users count: {userEmailsDB.Keys.Count}");
            foreach (var item in userEmailsDB) 
            {
                Console.WriteLine($"{item.Key}");
                foreach (var email in item.Value)
                {
                    Console.WriteLine($"- {email}");
                }
              
            }


        }
    }
}
