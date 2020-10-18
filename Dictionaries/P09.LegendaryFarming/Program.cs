using System;
using System.Linq;
using System.Collections.Generic;

namespace LegendaryFarming
{
    class LegendaryFarming
    {
        static void Main()
        {

            Dictionary<string, int> resources = new Dictionary<string, int>();
            Dictionary<string, int> junkResources = new Dictionary<string, int>();
            List<string> commands = new List<string>();
            string material = string.Empty;
            int quantity = 0;
            while (true)
            {
                    commands = Console.ReadLine().Split().ToList();
                for (int i = 0; i < commands.Count; i++)
                {

                    if (i == 0 || i % 2 == 0)
                    {
                        quantity = int.Parse(commands[i]);
                        if (material == "shards" || material == "motes" || material == "fragments")  
                        {
                            if (resources.ContainsKey(material))
                            {
                                resources[material] += quantity;
                                if (resources[material] >= 250)
                                {
                                    if (material == "shards")
                                    {
                                        Console.WriteLine("Shadowmourne obtained!");
                                        material = "shadowmourne";
                                        quantity = resources[material];
                                        
                                        break;
                                    }
                                    else if (material == "motes")
                                    {
                                        Console.WriteLine("Valanyr obtained!");
                                        material = "valanyr";
                                        quantity = resources[material];

                                        break;
                                    }
                                    else if (material == "fragments")
                                    {
                                        Console.WriteLine("Dragonwrath obtained!");
                                        material = "dragonwrath";
                                        quantity = resources[material];

                                        break;
                                    }
                                }
                                quantity = 0;
                                material = string.Empty;
                                
                            }
                        }
                        else
                        {
                            if (junkResources.ContainsKey(material))
                            {
                                junkResources[material] += quantity;
                                quantity = 0;
                                material = string.Empty;
                            }
                        }
                       
                    }
                    else if (i % 2 != 0)
                    {
                        material = commands[i].ToLower();
                        if (material == "shards" || material == "motes" || material == "fragments")
                        {
                            if (!resources.ContainsKey(material))
                            {

                                resources.Add(material, quantity);
                                if (resources[material] >= 250)
                                {
                                    if (material == "shards")
                                    {
                                        Console.WriteLine("Shadowmourne obtained!");
                                        material = "shadowmourne";
                                        quantity = resources[material];

                                        break;
                                    }
                                    else if (material == "motes")
                                    {
                                        Console.WriteLine("Valanyr obtained!");
                                        material = "valanyr";
                                        quantity = resources[material];


                                        break;
                                    }
                                    else if (material == "fragments")
                                    {
                                        Console.WriteLine("Dragonwrath obtained!");
                                        material = "dragonwrath";
                                        quantity = resources[material];


                                        break;
                                    }
                                }
                                material = string.Empty;
                            }
                        }
                        else
                        {
                            if (!junkResources.ContainsKey(material))
                            {

                                junkResources.Add(material, quantity);
                                material = string.Empty;
                            }
                        }
                       
                    }
                  
                }

                if (quantity >= 250)
                {
                    break;
                }

            }



        }
    }
}