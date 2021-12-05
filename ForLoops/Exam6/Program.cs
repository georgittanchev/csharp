using System;

namespace Exam6
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int firstNumber = 0;
            int secondnNumber = 0;
            int thirdNumber = 0;
            int nextNumber = 0;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                 nextNumber = int.Parse(number[i].ToString());

                if (i == 2)
                {
                    firstNumber = nextNumber;
                }
                else if (i == 1)
                {
                    secondnNumber = nextNumber;
                }
                else if (i == 0)
                {
                    thirdNumber = nextNumber;
                }

                for (int j = 1; j <= firstNumber; j++)
                {
                    for (int k = 1; k <= secondnNumber; k++)
                    {
                        for (int l = 1; l <= thirdNumber; l++)
                        {

                        }
                    }
                }

 
            }


        }
    }
}
