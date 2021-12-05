using System;

namespace _002.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {


            int inputNumber = int.Parse(Console.ReadLine());
            int lastNumber = 0;
            int numberSaver = 0;


           while (inputNumber != 0)
            {

                lastNumber += inputNumber % 10;
                inputNumber /= 10;

            }

            Console.WriteLine(lastNumber);




        }
    }
}
