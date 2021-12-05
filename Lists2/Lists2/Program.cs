using System;
using System.Linq;
using System.Collections.Generic;

namespace Lists2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberOfPassengers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int wagonMaxCapacity = int.Parse(Console.ReadLine());

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {

                List<string> splitedCommand = command.Split().ToList();


                if (splitedCommand[0] == "Add")
                {

                    int peopleInLastWagon = int.Parse(splitedCommand[1]);
                    if (peopleInLastWagon > wagonMaxCapacity)
                    {
                        break;
                    }
                    else
                    {
                        numberOfPassengers.Add(peopleInLastWagon);
                    }

                }
                else
                {
                    int peopleInLastWagon = int.Parse(splitedCommand[0]);
                    for (int i = 0; i < numberOfPassengers.Count; i++)
                    {
                        if (numberOfPassengers[i] + peopleInLastWagon <= wagonMaxCapacity)
                        {
                            numberOfPassengers[i] += peopleInLastWagon;
                            break;
                        }
                   
                    }
                }


            }
            Console.WriteLine(string.Join(" ", numberOfPassengers));
        }






        //            You will receive a list of wagons(integers) on the first line. Every integer represents the number of passengers that are currently
        //                in each of the wagons. On the next line, you will get the max capacity of each wagon(a single integer). Until you receive 
        //                "end" you will be given two types of input:
        //•	Add { passengers} – add a wagon to the end with the given number of passengers.
        //•	{ passengers}
        //            -find an existing wagon to fit every passenger, starting from the first wagon.
        //At the end print the final state of the train(each of the wagons, separated by a space).

    }
}

