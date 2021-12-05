using System;

namespace _FirstProgram
{
    class FirstProgram
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            PrintTriangleTopPart(number);
            PrintTriangleLowerPart(number);
        }

        static int PrintTriangleTopPart(int number)
        {
            int i, j, k;
            for (i = 1; i <= number; i++)
            {
                for (j = 1; j <= number - i; j++)
                {
                    Console.Write("");  
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write(k);
                }
                Console.WriteLine("");
            }
            return number;
        }

        static int PrintTriangleLowerPart(int number)
        {
            int i, j, k;
            for (i = 1; i <= number; i++)
            {
                for (j = 1; j <= number - i; j++)
                {
                     Console.Write(" ");  
                }
                for (k = 1; k <= j; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            return number;
        } 

        }
}   }
}