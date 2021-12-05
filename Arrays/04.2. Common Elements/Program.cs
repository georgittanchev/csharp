using System;
using System.Linq;


namespace _04._2._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] arr1 = Console.ReadLine().Split(' ');
            string[] arr2 = Console.ReadLine().Split(' ');

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {

                    if (arr1[i] == arr2[j])
                    {
                        Console.Write($"{arr1[i]} ");
                        break;
                    }


                }


            }






            //Write a program, which prints common elements in two arrays. 
            //    You have to compare the elements of the second array to the elements of the first.

        }
    }
}
