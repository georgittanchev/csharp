using System;
namespace _02.Sequence
{
    class Sequence
    {
        static void Main()
        {
            //Напишете програма, която чете число n, въведено от потребителя, и отпечатва всички числа ≤ n от редицата:
            //1, 3, 7, 15, 31, …. Всяко следващо число се изчислява като умножим предишното с 2 и добавим 1.

            int numberN = int.Parse(Console.ReadLine());
            int calculatedN = 1;

            while (calculatedN <= numberN)
            {
                
                    Console.WriteLine($"{calculatedN}");
                calculatedN = calculatedN * 2 + 1;


            }
        }
    }
}