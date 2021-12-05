using System;
using System.Linq;
using System.Collections.Generic;

namespace _2.TaskPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> taskHours = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> finalTaskHours = new List<int>();
            string command = string.Empty;
            int completeCounter = 0;
            int dropCounter = 0;
            int incompleteCounter = 0;

        
            while ((command = Console.ReadLine()) != "End")
            {
            
                string[] commandChanged = command.Split();
                if (commandChanged[0] == "Complete")
                {
                    int index = int.Parse(commandChanged[1]);

                    if (index <= taskHours.Count && index >= 0)
                    {
                        taskHours[index] = 0;
            
                    }
                }
                if (commandChanged[0] == "Change")
                {
                    int index = int.Parse(commandChanged[1]);
                    int newTime = int.Parse(commandChanged[2]);

                    if (index <= taskHours.Count && index >= 0)
                    {
                        taskHours[index] = newTime;

                    }
                }

                if (commandChanged[0] == "Drop")
                {
                    int index = int.Parse(commandChanged[1]);
                    if (index <= taskHours.Count && index >= 0)
                    {
                        
                            taskHours[index] = -1;
                      
                       

                    }

                }

                if (commandChanged[0] == "Count")
                {
                    if (commandChanged[1] == "Completed")
                    {
                        for (int i = 0; i < taskHours.Count; i++)
                        {
                            if (taskHours[i] == 0)
                            {
                                completeCounter++;
                            }
                        }
                        Console.WriteLine(completeCounter);
                    }
                    else if (commandChanged[1] == "Dropped")
                    {
                        for (int i = 0; i < taskHours.Count; i++)
                        {
                            if (taskHours[i] < 0)
                            {
                                dropCounter++;
                            }
                        }
                        Console.WriteLine(dropCounter);
                    }
                    else if (commandChanged[1] == "Incomplete")
                    {
              
                        for (int i = 0; i < taskHours.Count; i++)
                        {
                            if (taskHours[i] > 0 )
                            {
                                incompleteCounter++;
                            }
                            
                        }
                        Console.WriteLine(incompleteCounter);

                    }
                }

             
             
            }
            for (int i = 0; i < taskHours.Count; i++)
            {
                if (taskHours.Contains(-1))
                {
                    taskHours.Remove(-1);
                    i--;
                }
                if (taskHours.Contains(0))
                {
                    taskHours.Remove(0);
                    i--;
                }
            }
           
        
            Console.WriteLine(string.Join(" ", taskHours));
        }
    }
}
