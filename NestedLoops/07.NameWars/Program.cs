using System;

namespace _07.NameWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int score = 0;
            int theBiggest = 0;
            string winner = string.Empty;

            while (name != "STOP")
            {               
                for (int i = 0; i < name.Length; i++)
                {
                    score += name[i];
                    
                }
                if (theBiggest <= score)
                {
                    theBiggest = score;
                    winner = name;
                    
                }
                score = 0;
                name = Console.ReadLine();
            }
            Console.WriteLine($"Winner is {winner} - {theBiggest}!");
        }
    }
}
