using System;

namespace _05.Rotation
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] array = Console.ReadLine().Split();
            int numberOfRotations = int.Parse(Console.ReadLine());

            for(int i = 0; i < numberOfRotations; i++)
            {

                string temporary = array[0];

                for(int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];

                }

                array[array.Length - 1] = temporary;

            }

            Console.WriteLine(string.Join(' ', array));



            //Write a program that receives an array and number of rotations you have to perform(first element goes at the end) 
            //    Print the resulting array
        }
    }
}
