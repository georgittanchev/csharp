using System;
namespace _08.SameWord
{
    class SameWords
    {
        static void Main()
        {
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            word1 = word1.ToUpper();
            word2 = word2.ToUpper();
            if (word1 == word2 && word2 == word1)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}

//8. Еднакви думи
//Да се напише програма, която чете две думи, въведени от потребителя, и проверява дали са еднакви.Да не
//се прави разлика между главни и малки думи.Да се изведе &quot; yes&quot; или &quot;no&quot;.