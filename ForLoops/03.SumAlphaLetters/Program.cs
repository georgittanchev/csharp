using System;

namespace _03.SumAlphaLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете текст(стринг), въведен от потребителя, и изчислява и отпечатва 
            //    сумата от стойностите на гласните букви според таблицата по - долу:

            //буква       a   e   i   o   u
            //стойност    1   2   3   4   5

            int sum = 0;

            string text = Console.ReadLine();

            

            for (int i = 0; i < text; i++)
            {
                text.ToCharArray();
                

                if (text == "a")
                {
                    sum++;
                }
                else if (text == "e")
                {
                    sum += 2;
                }
                else if (text == "i")
                {
                    sum += 3;
                }
                else if (text == "o")
                {
                    sum += 4;
                }
               else if (text == "u")
                {
                    sum += 5;
                }
            }
            Console.WriteLine(sum);

        }
    }
}
