using System;

namespace _09.TriangleOfNumbers
{


    class TriangleOfNumber
    {

        static void Main()
        {


            int number = int.Parse(Console.ReadLine());

            for (int col = 1; col <= number; col++)
            {

                for (int row = 1; row <= col; row++)
                {

                    Console.Write(" " + (col));
                }

                Console.WriteLine();
              
            }


        }
    }
}