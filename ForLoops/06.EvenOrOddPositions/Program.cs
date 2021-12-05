using System;

namespace _06.EvenOrOddPositions
{
    class Program
    {
        static void Main(string[] args)
        {

            int numbersCount = int.Parse(Console.ReadLine());
            int counter = 0;
            double number = 0;
            double oddNumber = 0;
            double evenNumber = 0;
            double sumEven = 0;
            double sumOdd = 0;
            double maxEven = double.MinValue;
            double minEven = double.MaxValue;
            double maxOdd = double.MinValue;
            double minOdd = double.MaxValue;

            for (counter = 1; counter < numbersCount + 1; counter++)
            {
                number = double.Parse(Console.ReadLine());

                if (counter % 2 == 0)
                {
                    evenNumber = number;

                    if (evenNumber > maxEven)
                    {
                        maxEven = evenNumber;
                    }
                     if (evenNumber < minEven)
                    {
                        minEven = evenNumber;
                    }
                    sumEven += evenNumber;
                }
                else
                {
                    oddNumber = number;

                    if (oddNumber > maxOdd)
                    {
                        maxOdd = oddNumber;
                    }
                    if (oddNumber < minOdd)
                    {
                        minOdd = oddNumber;
                    }
                    sumOdd += oddNumber;
                }
              
               
            }
     

            Console.WriteLine($"OddSum={sumOdd:F2},");

            if (minOdd == double.MaxValue || maxOdd == double.MinValue)
            {
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={minOdd:F2},");
                Console.WriteLine($"OddMax={maxOdd:F2},");
            }
           
            Console.WriteLine($"EvenSum={sumEven:F2},");

            if (minEven == double.MaxValue || maxEven == double.MinValue)
            {
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMin={minEven:F2},");
                Console.WriteLine($"EvenMax={maxEven:F2}");
            }
         
        }
    }
}
