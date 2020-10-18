using System;
namespace _04.CountNumbers
{
    class CountNumbers
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number == 1)
            {
                Console.WriteLine("one");
            }
            else if (number ==2)
            {
                Console.WriteLine("two");
            }
            else if (number == 3)
            {
                Console.WriteLine("three");
            }
            else if (number == 4)
            {
                Console.WriteLine("four");
            }
            else if (number == 5)
            {
                Console.WriteLine("five");
            }
            else if (number == 6)
            {
                Console.WriteLine("six");
            }
            else if (number == 7)
            {
                Console.WriteLine("seven");
            }
            else if (number == 8)
            {
                Console.WriteLine("eight");
            }
            else if (number == 9)
            {
                Console.WriteLine("nine");
            }
            else if (number >9)
            {
                Console.WriteLine("number is too great");
            }

        }
    }
}

//5. Изписване на число до 9 с думи
//Да се напише програма, която чете цяло число в диапазона[1…9], въведено от потребителя и го изписва с
//думи на английски език.Ако числото е извън диапазона, изписва &quot;number too big&quot;.