using System;

namespace _04.Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int testing = 0;
          

            for (int i = 0; i <= number; i++)
            {
                for (int j = 0; j <= number; j++)
                {
                    for (int k = 0; k <= number; k++)
                    {
                        for ( int l = 0; l <= number; l++)
                        {
                            for ( int g = 0; g <= number; g++)
                            {
                                sum = i + j + k + l + g;

                                if (sum == number)
                                {
                                    testing++;
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine(testing);
        }
    }
}
