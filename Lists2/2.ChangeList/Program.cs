using System;
using System.Linq;
using System.Collections.Generic;

namespace _2.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                List<string> commandSeparated = command.Split().ToList();
                string order = commandSeparated[0];
                int number = int.Parse(commandSeparated[1]);
                int insertPosition;
                if (commandSeparated.Count > 2)
                {
                    insertPosition = int.Parse(commandSeparated[2]);
                    numbers.Insert(insertPosition, number);
                }
                
                if (order == "Delete")
                {
                    numbers.RemoveAll(x => x == number);
                }

             

            }
            Console.WriteLine(string.Join(" ", numbers),StringSplitOptions.RemoveEmptyEntries);





//            Write a program, which reads a list of integers from the console and receives commands, which manipulate the list.
//                Your program may receive the following commands:
//•	Delete { element} – delete all elements in the array, which are equal to the given element.
//•	Insert { element}
//            { position} – insert an element and the given position.
//You should stop the program when you receive the command "end".Print the numbers in the array separated by a single whitespace.

        }
    }
}
