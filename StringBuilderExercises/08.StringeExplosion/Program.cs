using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _08.StringExplosion
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int power = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    power += int.Parse(input[i + 1].ToString());
                    while (input.Length > i+1 && power > 0)
                    {
                        if (input[i+1] == '>')
                        {
                            break;
                        }
                        else
                        {
                            input = input.Remove(i+1, 1);
                            power--;
                        }
                    }

                }

            }

            Console.WriteLine(input);
            
           

        }
    }
}