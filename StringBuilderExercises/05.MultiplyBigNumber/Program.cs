using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger firstNumber = BigInteger.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            BigInteger result = firstNumber * secondNumber;

            Console.WriteLine(result);


        }
    }
}
