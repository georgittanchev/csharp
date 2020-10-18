using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace StringBuilder12
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = string.Empty;

            while ((words = Console.ReadLine()) != "end")
            {
                char[] reversed = words.Reverse().ToArray();


                Console.WriteLine($"{string.Join("", words)} = {string.Join("", reversed)}");
               
            }


        }
    }
}
