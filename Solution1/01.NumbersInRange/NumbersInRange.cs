using System;
namespace _01.NumbersInRange
{
    class NumbersInRange
    {
        static void Main()
        {

            //            Напишете програма, която въвежда цяло положително число n в диапазона[1…100].При въвеждане на
            //число извън посочения диапазон, да се отпечата съобщение за грешка и да се въведе ново число.

            int numberN = int.Parse(Console.ReadLine());

            while (true)
            {
                if (numberN >= 1 && numberN <= 100)
                {
                    Console.WriteLine($"The number is: {numberN}");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                    numberN = int.Parse(Console.ReadLine());
                }
            }
            

           

        }
    }
    
}