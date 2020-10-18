using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_By_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> command = Console.ReadLine().Split().ToList();
            List<string> list = new List<string>();
            int age = 0;
            while (command[0] != "End")
            {

                string name = command[0].ToString();
                string id = command[1].ToString();
                age = int.Parse(command[2]);
                dynamic person = new { name, id, age };

                list.Add(person);
                command = Console.ReadLine().Split().ToList();

            }
            if (command[0] == "End")
            {
                List<string> result = age.OrderByDescending(row => row.age).ToList();
                foreach (var item in result)
                {
                    Console.WriteLine($"{item.name} with ID: {item.id} is {item.age} years old.");
                }
            }
        }
    }
}