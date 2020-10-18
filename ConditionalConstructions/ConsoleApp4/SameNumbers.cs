using System;
namespace _05.SameNumbers
{
    class SameNumbers
    {
        static void Main()
        {
            double numbers = double.Parse(Console.ReadLine());
            double numbers2 = double.Parse(Console.ReadLine());
            double numbers3 = double.Parse(Console.ReadLine());

            if (numbers == numbers2 && numbers == numbers3 && numbers2 == numbers3)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}


//5. Еднакви 3 числа
//Да се въведат 3 числа и да се отпечата дали са еднакви(yes / no)