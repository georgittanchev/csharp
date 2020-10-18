using System;

namespace _008.Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {


            int kegs = int.Parse(Console.ReadLine());
            double volume = 0;
            double bestKeg = 0;
            string bestModel = ""; 

            for (int i = 0; i < kegs; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                volume = Math.PI * Math.Pow(radius, 2) * height;

                if (volume > bestKeg)
                {
                    bestKeg = volume;
                    bestModel = model;
                }
            }

            Console.WriteLine(bestModel);



//            Write a program, which calculates the volume of n beer kegs. You will receive in total 3 * n lines.
//                Each three lines will hold information for a single keg.First up is the model of the keg, 
//                after that is the radius of the keg, and lastly is the height of the keg.
//Calculate the volume using the following formula: π* r^ 2 * h.
//At the end, print the model of the biggest keg.
//Input
//You will receive 3 * n lines.Each group of lines will be on a new line:
//•	First – model – string.
//•	Second –radius – floating - point number
//•	Third – height – integer number
//            •	First – model – string.
//•	Second –radius – floating - point number
//•	Third – height – integer number



        }
    }
}
