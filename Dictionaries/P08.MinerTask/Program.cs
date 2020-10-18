using System;
using System.Linq;
using System.Collections.Generic;

namespace P08.MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            string resource = string.Empty;
            string quantity = string.Empty;
            Dictionary<string, double> materialAndAmount = new Dictionary<string, double>();
            int counter = 1;
            while ((command = Console.ReadLine()) != "stop")
            {
                if (counter % 2 != 0)
                {
                    resource = command;
                    if (!materialAndAmount.ContainsKey(resource))
                    {
                        materialAndAmount.Add(resource, 0);
                    }

                }
                else
                {
                    quantity = command;

                    materialAndAmount[resource] += double.Parse(quantity);
                }
                counter++;
            }

            foreach (var item in materialAndAmount)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
