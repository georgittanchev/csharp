using System;

namespace _002.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = string.Empty;

            VowelsCount(text);



            //Write a method that receives a single string and prints the count of the vowels. Use appropriate name for the method.
        }

        static string VowelsCount(string countOfVowels)
        {
            string text = Console.ReadLine();
            int counterVowel = 0;
            for (int i = 0; i < text.Length; i++)
            {
                bool isVowel = false;
                if (text[i] == 'a' || text[i] == 'e' || text[i] == 'i' || text[i] == 'o' || text[i] == 'u' || text[i] == 'A' || text[i] == 'E'
                    || text[i] == 'I' || text[i] == 'O' || text[i] == 'U')
                {
                    isVowel = true;
                }


                if (isVowel)
                {
                    counterVowel++;
                }
            }
        
            Console.WriteLine(counterVowel);
            return countOfVowels;
        }
    }
}
