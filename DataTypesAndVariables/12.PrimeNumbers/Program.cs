using System;

namespace _12.PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int ___Do___ = int.Parse(Console.ReadLine());
            for (int takoa = 2; takoa <= ___Do___; takoa++)
            {
                bool takovalie = true;
                for (int cepitel = 2; cepitel < takoa; cepitel++)
                {
                    if (takoa % cepitel == 0 && takoa != cepitel)
                    {
                        takovalie = false;
                        break;
                    }
                    else
                    {
                        takovalie = true;
                    }
                }
               string PrimeNumbers = takovalie.ToString().ToLower();
                Console.WriteLine($"{takoa} -> {PrimeNumbers}");
               
            }





        }
    }
}
