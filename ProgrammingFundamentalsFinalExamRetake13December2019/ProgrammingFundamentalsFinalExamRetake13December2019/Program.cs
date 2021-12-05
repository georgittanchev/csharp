using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PFFinalExamRetake13December2019
{
    class Program
    {
        static void Main(string[] args)
        {
            string skill = Console.ReadLine();
            string input = string.Empty;
            bool exist = false;
            while ((input = Console.ReadLine()) != "For Azeroth")
            {
                exist = false;
                string[] splittedInput = input.Split();

                if (splittedInput.Contains("GladiatorStance"))
                {
                    skill = skill.ToUpper();
                    Console.WriteLine(skill);
                    exist = true;
                  
                }
                else if (splittedInput.Contains("DefensiveStance"))
                {
                    skill = skill.ToLower();
                    Console.WriteLine(skill);
                    exist = true;

                }
                else if (splittedInput.Contains("Dispel"))
                {
                    exist = true;
                    int index = int.Parse(splittedInput[1]);
                    char letter = char.Parse(splittedInput[2]);
                    if (index > skill.Length - 1 || index < 0)
                    {
                        Console.WriteLine("Dispel too weak.");
                      
                    }
                    else
                    {
                        skill = skill.Remove(index, 1);
                        skill = skill.Insert(index, letter.ToString());
                        Console.WriteLine("Success!");
                      
                    }
                }
                else if (splittedInput.Contains("Target"))
                {
                    if (splittedInput[1] == "Change")
                    {
                        exist = true;
                        string stringToBeChanged = splittedInput[2];
                        string newString = splittedInput[3];
                        if (skill.Contains(stringToBeChanged))
                        {
                            skill = skill.Replace(stringToBeChanged, newString);
                            Console.WriteLine(skill);
                        }
                             
                    }
                    else if (splittedInput[1] == "Remove")
                    {
                        exist = true;
                        string stringToBeChanged = splittedInput[2];
                        int indexOf = skill.IndexOf(stringToBeChanged);
                        int lenght = stringToBeChanged.Length;
                        if (indexOf != - 1)
                        {
                            skill = skill.Remove(indexOf, lenght);
                            Console.WriteLine(skill);
                        }
                            
                    }
                }
                if (exist == false)
                {
                    Console.WriteLine("Command doesn't exist!");
                }
               
               
            }
        }
    }
}
