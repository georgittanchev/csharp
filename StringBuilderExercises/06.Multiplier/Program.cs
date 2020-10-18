using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _06.Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstNumber = Console.ReadLine().ToCharArray();    
            int secondNumber = int.Parse(Console.ReadLine());
            int whatMoves = 0;
            int whatRemains = 0;
            StringBuilder bigNumber = new StringBuilder();
            int asANumber = 0; ;
            int sum = 0;
            string result = string.Empty;
            for (int i = firstNumber.Length-1; i >= 0; i--)
            {
               asANumber =  int.Parse(firstNumber[i].ToString());
                sum = (asANumber * secondNumber) + whatMoves;
                whatMoves = sum / 10;
                whatRemains = sum % 10;
                bigNumber.Append(whatRemains);
            }

            bigNumber.Append(whatMoves);
        
            char[] charArray = bigNumber.ToString().ToCharArray();
            Array.Reverse(charArray);
            result = new string(charArray).TrimStart('0');

            if (result == string.Empty)
            {
                Console.WriteLine(0);
            }

            else
            {
                Console.WriteLine(result);
            }

        }
}
}
