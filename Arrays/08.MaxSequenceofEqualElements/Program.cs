using System;
using System.Linq;

namespace _fuckoff
{
    class fuckoff
    {
        static void Main()
        {


            string[] input = Console.ReadLine().Split();
            string se = input[1];
            string top = string.Empty;

            for (int i = 1; i < input.Length; i++)
            {
                if (input [i] == input[i-1])
                {
                    se += " " + input[i-1];
                }

                else
                {
                    se = input[i];
                }

                if (se.Length   > top.Length)
                {
                    top = se;
                }
            }
            Console.WriteLine(top);










        }
    }
}