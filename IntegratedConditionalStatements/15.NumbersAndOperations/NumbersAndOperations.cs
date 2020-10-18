using System;
namespace _15.NumbersAndOperations
{
    class NumbersAndOperations
    {
        static void Main()
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string n3 = Console.ReadLine();
            double result = 0;



            if (n3 == "-")
            {
                result = n1 - n2;
               if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} {n3} {n2} = {result} - even");
                } 
               else
                {
                    Console.WriteLine($"{n1} {n3} {n2} = {result} - odd");
                }
            }
            else if (n3 == "+")
            {
                result = n1 + n2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} {n3} {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} {n3} {n2} = {result} - odd");
                }
            }
            else if (n3 == "*")
            {
                result = n1 * n2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} {n3} {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} {n3} {n2} = {result} - odd");
                }
            }
            else if (n3 == "/")
            {
                result = n1 / n2;
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    Console.WriteLine($"{n1} {n3} {n2} = {result:F2}");
                }
                
                
            }
           else if (n3 == "%")
            {
                result = n1 % n2;
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    Console.WriteLine($"{n1} {n3} {n2} = {result}");
                }
            }
        }
    }
}