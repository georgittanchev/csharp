using System;

namespace NxnMatrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int integer = int.Parse(Console.ReadLine());
            NxNMatrix(integer);
        }

        static void NxNMatrix (int first)
        {
            for (int i = 0; i <= first-1; i++)
            {
                Console.Write(first + " ");
                for (int o = 0; o < first-1; o++)
                {
                    Console.Write(first + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
