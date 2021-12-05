using System;
using System.Linq;
using System.Collections.Generic;

namespace _3.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();
            for (int i = 0; i < numberOfCommands; i++)
            {

                List<string> command = Console.ReadLine().Split().ToList();
                string name = command[0];
                if (command.Count == 3)
                {
                    if (guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(name);
                    }

                }
                else if (command.Count == 4)
                {
                    if (guestList.Contains(name))
                    {
                        guestList.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }

                }

            }
            Console.WriteLine(string.Join("\n", guestList));




            //            Write a program that keeps track of guests, that are going to a house party. On the first line of input, 
            //                you are going to receive the number of commands you are going to receive.On the next lines you are going to 
            //                receive one of the following messages:
            //-"{name} is going!"
            //- "{name} is not going!"
            //If you receive the first message, you have to add the person if he / she is not in the list and if 
            //                he / she is in the list print on the console: "{name} is already in the list!".If you receive the second 
            //                message, you have to remove the person if he / she is in the list and if not print: "{name} is not in the list!".
            //                    At the end print all the guests.

        }


    }
}
