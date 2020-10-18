using System;
using System.Linq;

namespace _06.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] topInteger = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string top = "";
            int j = 0;
            bool whatthefuck = true;

            for(int i= 0; i < topInteger.Length; i++)
            {
                whatthefuck = true;

                for (j = i + 1; j < topInteger.Length; j++)
                {

                  if(topInteger[i] <= topInteger[j])
                    {
                        whatthefuck = false;
                        break;
                    }

                }
                if (whatthefuck == true)
                {
                    top += topInteger[i] + " ";
                }
                
            }
            Console.WriteLine(string.Join(" ", top));




            //Write a program to find all the top integers in an array. 
            //    A top integer is an integer which is bigger than all the elements to its right. 
        }
    }
}
