using System;
namespace _08.CookieFactory
{
    class CookieFactory
    {
        static void Main()
        {
            //string product = string.Empty;
            int batchNumbers = int.Parse(Console.ReadLine());
            bool isCooked = false;
            int sugar = 0;
            int flour = 0;
            int eggs = 0;

            for (int i = 1; i <= batchNumbers; i++)
            {

                string product = Console.ReadLine();


                while (product != "Bake!")
                {

                    if (product == "sugar")
                    {
                        sugar++;
                    }
                    else if (product == "eggs")
                    {
                        eggs++;
                    }
                    else if (product == "flour")
                    {
                        flour++;
                    }

                    if (sugar >= 1 && eggs >= 1 && flour >= 1)
                    {
                        isCooked = true;
                    }
                    product = Console.ReadLine();
                }
                 if (product == "Bake!")
                 {
                    if (!isCooked)
                    {
                        Console.WriteLine("The batter should contain flour, eggs and sugar!");
                        i -= 1;
                        
                    }
                    else
                    {
                        Console.WriteLine($"Baking batch number {i}...");
                        flour = 0;
                        sugar = 0;
                        eggs = 0;
                        isCooked = false;
                      
                    }                 
                 }
            }
        }
    }
}