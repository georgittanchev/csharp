using System;

namespace _07.Yardening
{
    class Program
    {
        static void Main(string[] args)
        {

            double m2 = double.Parse(Console.ReadLine());
            double amount =  7.61 * m2 ;
            double finalAmount = amount * 0.82;

            Console.WriteLine($"The final price is: {finalAmount:F2} lv.");
            Console.WriteLine($"The discount is: {(amount*0.18):F2} lv.");




        }
    }
}
