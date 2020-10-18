using System;
namespace _11.Animals
{
    class Animals
    {
        static void Main()

        {
            string animal = Console.ReadLine();
            animal = animal.ToLower();
       
            
           

            switch (animal)
                 
            {
                case "dog":
                    {
                        Console.WriteLine("Mammal");
                        break;

                    }
                case "crocodile": 
                    {
                        Console.WriteLine("reptile");
                        break;
                    }
                    case "tortoise":
                    {
                        Console.WriteLine("reptile");
                        break;
                    }
                    case "snake":
                    {
                        Console.WriteLine("reptile");
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Unkown");
                        break;
                    }

            }
        }
    }
}
//11. Клас животно
//Напишете програма, която отпечатва класа на животното според неговото име, въведено от потребителя.
// dog -&gt; mammal
// crocodile, tortoise, snake -&gt; reptile
// others -&gt; unknown