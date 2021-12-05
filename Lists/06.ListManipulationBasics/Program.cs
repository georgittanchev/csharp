using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> numbers = Console.ReadLine().Split().ToList();


            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] input = command.Split();

                if (input[0] == "Add")
                {
                    numbers.Add(input[1]);
                }
                if (input[0] == "Remove")
                {
                    numbers.Remove(input[1]);
                }
                if (input[0] == "RemoveAt")
                {
                    int value = int.Parse(input[1]);
                    numbers.RemoveAt(value);
                }
                if (input[0] == "Insert")
                {
                    
                    int value = int.Parse(input[2]);
                    numbers.Insert(value, input[1]);
                }

                command = Console.ReadLine();
            }

            Console.Write(string.Join(" ", numbers));



//            Write a program that reads a list of integers.Then until you receive "end", you will receive different commands:
//            Add { number}: add a number to the end of the list.
//Remove { number}: remove a number from the list.
//RemoveAt { index}: remove a number at a given index.
//Insert { number}
//            { index}: insert a number at a given index.
//Note: All the indices will be valid!
//When you receive the "end" command, print the final state of the list(separated by spaces).

        }
    }
}
