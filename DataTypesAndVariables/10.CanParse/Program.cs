using System;

namespace _10.CanParse
{

    class CanParse
    {

        static void Main()
        {


            string input = Console.ReadLine();

            while (input != "END")
            {


                bool intTryParse = int.TryParse(input, out _);
                bool doubleTryParse = double.TryParse(input, out _);
                bool charTryParse = char.TryParse(input, out _);
                bool boolTryParse = bool.TryParse(input, out _);



                if (intTryParse)
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (doubleTryParse)
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (charTryParse)
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (boolTryParse)
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
                input = Console.ReadLine();
            }

           
        }
        
    }
}