using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _07.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] line = Console.ReadLine().ToCharArray();
            StringBuilder realLine = new StringBuilder();
            for (int i = 0; i < line.Length; i++)
            {
                if (i != line.Length - 1)
                {
                    if (line[i] == line[i + 1])
                    {
                        continue;
                    }
                    else
                    {
                        realLine.Append(line[i]);
                    }
                }

                if (i == line.Length - 1)
                {
                    realLine.Append(line[i]);
                }
                

            }

            Console.WriteLine(realLine);





        }
    }
}
