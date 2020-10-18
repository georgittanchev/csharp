using System;
namespace _06.Number100to200
{
    class Number100to200
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 100)
            {
                Console.WriteLine("Less then 100");
            }
            else if (number <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else
            {
                Console.WriteLine("Greater then 200");
            }
                
            
        }
    }
}


//6. Число от 100 до 200
//Да се напише програма, която чете цяло число, въведено от потребителя и проверява, дали е под 100, между
//100 и 199 или над 200. Да се отпечатат съответно съобщения, като в примерите по-долу:
