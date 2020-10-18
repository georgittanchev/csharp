using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> numbers = Console.ReadLine().Split().ToList();

            string command = Console.ReadLine();
            int counterAdd = 0;
            int counterRemove = 0;
            int counterRemoveAt = 0;
            int counterInsert = 0;

            while (command != "end")
            {
                string[] input = command.Split();

                if (input[0] == "Contains")
                {

                    bool right = numbers.Contains(input[1]);
                    if (!right)
                    {
                        Console.WriteLine("No such number");
                    }

                    if (right)
                    {
                        Console.WriteLine("Yes");
                    }

                }

                if (input[0] == "PrintEven")
                {

                    List<int> intList = numbers.Select(int.Parse).ToList();
                    List<int> evenNumbers = new List<int>();

                    for (int i = 0; i < intList.Count; i++)

                    {
                        if (intList[i] % 2 == 0)

                        {

                            evenNumbers.Add(intList[i]);
                        }

                    }

                    Console.WriteLine(string.Join(" ", evenNumbers));
                }

                if (input[0] == "PrintOdd")
                {
                    List<int> intList = numbers.Select(int.Parse).ToList();
                    List<int> oddNumbers = new List<int>();

                    for (int i = 0; i < intList.Count; i++)
                    {
                        if (intList[i] % 2 == 1)
                        {

                            oddNumbers.Add(intList[i]);
                        }

                    }

                    Console.WriteLine(string.Join(" ", oddNumbers));
                }

                if (input[0] == "GetSum")
                {
                    List<double> intList = numbers.Select(double.Parse).ToList();

                    double sum = intList.Sum();

                    Console.WriteLine(string.Join(" ", sum));
                }

                if (input[0] == "Filter")
                {
                    List<double> intList = numbers.Select(double.Parse).ToList();
                    List<double> filteredList = numbers.Select(double.Parse).ToList();
                    int value = int.Parse(input[2]);

                    if (input[1] == ">")
                    {
                        filteredList = intList.Where( x => x > value).ToList();
                    }
                    if (input[1] == "<")
                    {
                        filteredList = intList.Where(x => x < value).ToList();
                    }
                    if (input[1] == ">=")
                    {
                        filteredList = intList.Where(x => x >= value).ToList();
                    }
                    if (input[1] == "<=")
                    {
                        filteredList = intList.Where(x => x <= value).ToList();
                    }
                    Console.WriteLine(string.Join(" ", filteredList));
                }

                if (input[0] == "Add")
                {
                    numbers.Add(input[1]);
                    counterAdd += 1;
                }
                if (input[0] == "Remove")
                {
                    numbers.Remove(input[1]);
                    counterRemove += 1;
                }
                if (input[0] == "RemoveAt")
                {
                    int value = int.Parse(input[1]);
                    numbers.RemoveAt(value);
                    counterRemoveAt += 1;
                }
                if (input[0] == "Insert")
                {

                    int value = int.Parse(input[2]);
                    numbers.Insert(value, input[1]);
                    counterInsert += 1;
                }


                command = Console.ReadLine();
            }
            if (counterInsert >= 1 || counterAdd >= 1 || counterRemove >= 1 || counterRemoveAt >= 1)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }


        }
    }
}
