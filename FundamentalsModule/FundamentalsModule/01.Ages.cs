using System;

namespace FundamentalsModule
{
    class Ages
    {
        static void Main(string[] args)
        {

            int age = int.Parse(Console.ReadLine());
            string bounders = string.Empty;

            if (age >= 0 && age <= 2)
            {
                bounders = "baby";
            }
            else if (age >= 3 && age <= 13)
            {
                bounders = "child";
            }
            else if (age >= 14 && age <= 19)
            {
                bounders = "teenager";
            }
            else if (age >= 20 && age <= 65)
            {
                bounders = "adult";
            }
            else if (age >= 66)
            {
                bounders = "elder";
            }

            Console.WriteLine(bounders);
       

        }
    }
}
