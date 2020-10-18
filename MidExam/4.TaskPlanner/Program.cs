using System;
using System.Linq;
using System.Collections.Generic;

namespace _4.TaskPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> incompleteList = new List<int>();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] exactCommand = command.Split();
                string order = exactCommand[0];
                int completeCounter = 0;
                int incompleteCounter = 0;
                int droppedCounter = 0;

                if (order == "Complete")
                {
                    int index = int.Parse(exactCommand[1]);

                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers[index] = 0;
                    }
                }
                if (order == "Change")
                {
                    int index = int.Parse(exactCommand[1]);
                    int time = int.Parse(exactCommand[2]);
                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers[index] = numbers[time];
                    }
                }
                if (order == "Drop")
                {
                    int index = int.Parse(exactCommand[1]);
    
                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers[index] = -1;
                    }
                }
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] > 0)
                    {
                        incompleteCounter++;
                    }
                    if (numbers[i] < 0)
                    {
                        droppedCounter++;
                    }
                    if (numbers[i] == 0)
                    {
                        completeCounter++;
                    }
                }
                if (order == "Count")
                {
                    string what = exactCommand[1];

                    if (what == "Completed")
                    {
                        Console.WriteLine(completeCounter);
                    }
                }
                if (order == "Count")
                {
                    string what = exactCommand[1];

                    if (what == "Incomplete")
                    {
                        Console.WriteLine(incompleteCounter);
                    }
                }
                if (order == "Count")
                {
                    string what = exactCommand[1];

                    if (what == "Dropped")
                    {
                        Console.WriteLine(droppedCounter);
                    }
                }
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] < 0)
                    {

                        numbers.Remove(i);
                    }
                    if (numbers[i] == 0)
                    {
                        numbers.Remove(i);
                    }

                }

            }
       
            Console.WriteLine(string.Join(" ", numbers));
           


        }
    }
}
