using System;
using System.Linq;
using System.Collections.Generic;

namespace _4.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = string.Empty;
            int number = 0;
            int index = 0;
            while ((command = Console.ReadLine()) != "End")
            {
                List<string> commandWordCounter = command.Split().ToList();
                string order = commandWordCounter[0];
               
                if (order == "Add")
                {
                    number = int.Parse(commandWordCounter[1]);
                    numbers.Add(number);
                }
                else if (order == "Insert")
                {
                  
                    number = int.Parse(commandWordCounter[1]);
                    index = int.Parse(commandWordCounter[2]);
                    if (index >=0 && index < numbers.Count)
                    {
                        numbers.Insert(index, number);
                        
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                    
                }
                else if (order == "Remove")
                {
                    index = int.Parse(commandWordCounter[1]);
                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers.RemoveAt(index);
                        
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                   
                }
                else if (order == "Shift")
                {
                    int numberOfShifts = int.Parse(commandWordCounter[2]);
                    if (commandWordCounter[1] == "left")
                    {
                        numberOfShifts = numberOfShifts % numbers.Count;
                        for (int i = 0; i < numberOfShifts; i++)
                        {
                            numbers.Add(numbers[0]);
                            numbers.RemoveAt(0);

                        }

                    }
                    else if (commandWordCounter[1] == "right")
                    {
                        numberOfShifts = numberOfShifts % numbers.Count;
                        for (int i = 0; i < numberOfShifts; i++)
                        {
                            int lastEl = numbers[numbers.Count - 1];

                            numbers.RemoveAt(numbers.Count-1);
                            numbers.Insert(0, lastEl);
                            
                        }
                    }
                }

            }
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
