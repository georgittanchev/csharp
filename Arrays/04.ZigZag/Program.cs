using System;

namespace _04.ZigZag
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            string[] arrayOne = new string[numberOfLines];
            string[] arrayTwo = new string[numberOfLines];
            string[] current = new string[numberOfLines];

            for(int i = 0; i < numberOfLines; i++)
            {
                current = Console.ReadLine().Split();


                if (i % 2 == 0)
                {
                    arrayOne[i] = current[0];
                    arrayTwo[i] = current[1];
                }
                else
                {
                    arrayOne[i] = current[1];
                    arrayTwo[i] = current[0];
                }
            }
            Console.WriteLine(string.Join(' ', arrayOne));
            Console.WriteLine(string.Join(' ', arrayTwo));


            //Write a program which creates 2 arrays.You will be given an integer n.
            //    On the next n lines you get 2 integers.Form 2 arrays as shown below.
        }
    }
}
