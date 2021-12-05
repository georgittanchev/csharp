using System;
using System.Linq;
using System.Collections.Generic;

namespace _14.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> classRoom = new Dictionary<string, List<double>>();
            int numberOfLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfLines; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!classRoom.ContainsKey(studentName))
                {
                    classRoom[studentName] = new List<double>();
                }

                classRoom[studentName].Add(grade);
            }

            foreach (var item in classRoom)
            {
                if (item.Value < 4.50)
                {
                    classRoom.Remove(item.Key);

                }
            }
        }
    }
}
