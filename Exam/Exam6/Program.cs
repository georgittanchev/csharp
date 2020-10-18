using System;

namespace Exam6
{
    class Program
    {
        static void Main(string[] args)
        {

            string words = string.Empty;
            double score = 0;
            double value = 0;
            double theBiggest = 0;
            string theBiggestName = string.Empty;
            bool hasVawels = false;


            while (words != "End of words")
            {

                 words = Console.ReadLine();


                if (words == "End of words")
                {
                    Console.WriteLine($"The most powerful word is {theBiggestName} - {theBiggest}");
                    break;

                }

                for (int i = 0; i < words.Length; i++)
                {

                    score += words[i];

                    if ((words[i] == 'a' || words[i] == 'e' || words[i] == 'i' || words[i] == 'o' || words[i] == 'u' || words[i] == 'y'
                        || words[i] == 'A' || words[i] == 'I' || words[i] == 'O' || words[i] == 'U' || words[i] == 'Y' || words[i] == 'E') 
                        && i == 0)
                    {
                        hasVawels = true;
                    }
                    

                    
                }

                if (hasVawels)
                {
                    value = score * words.Length;
                }

                else
                {
                    value = Math.Floor(score / words.Length);
                }

                if (theBiggest < value)
                {
                    theBiggest = value;
                    theBiggestName = words;
                }

                hasVawels = false;
                score = 0;
            }


        }
    }
}
