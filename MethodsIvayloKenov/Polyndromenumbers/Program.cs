using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Polyndromenumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            bool isPolyndrome = false;
            int reversed = 0;
            while (command != "END")
            {
                int temporary;
                TryHard(command, ref isPolyndrome, ref reversed);

                temporary = 0;
                reversed = 0;
                isPolyndrome = false;
                command = Console.ReadLine();
            }


        }

        private static void TryHard(string command, ref bool isPolyndrome, ref int reversed)
        {
            int number = int.Parse(command);
            int temporary = number;
            while (number != 0)
            {

                int lastDigit = number % 10;
                reversed = reversed * 10 + lastDigit;
                number /= 10;
            }

            if (reversed == temporary)
            {
                isPolyndrome = true;
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
