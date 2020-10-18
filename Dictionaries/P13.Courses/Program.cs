using System;
using System.Linq;
using System.Collections.Generic;

namespace _P13.Courses
{
   class Courses
    {
        static void Main()
        {

            Dictionary<string, int> courses = new Dictionary<string, int>();
            SortedDictionary<string, string> students = new SortedDictionary<string, string>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] input = command.Split(" : ").ToArray();
                string studentName = input[1];
                string courseName = input[0];
                if (!courses.ContainsKey(courseName))
                {
                    courses[courseName] = 0;
                }
                    courses[courseName]++;
                    students[studentName] = courseName; 
            }

            courses = courses.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, b => b.Value);

            foreach (var item in courses)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");

                foreach (var items in students)
                {
                    if (item.Key == items.Value)
                    {
                        Console.WriteLine($"-- {items.Key}");
                    }
                }
            }


        }
    }
}