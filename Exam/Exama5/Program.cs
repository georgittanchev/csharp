using System;

namespace Exama5
{
    class Program
    {
        static void Main(string[] args)
        {

            string teamName = Console.ReadLine();
            double playedGames = int.Parse(Console.ReadLine());
            int points = 0;
            double w = 0;
            double d = 0;
            double l = 0;
            double winRate = 0;

            for (int i = 0; i < playedGames; i++)
            {
                char outcome = char.Parse(Console.ReadLine());


                if (outcome == 'W')
                {
                    points += 3;
                    w++;
                }
                else if (outcome == 'D')
                {
                    points += 1;
                    d++;
                }
                else if (outcome == 'L')
                {
                    points += 0;
                    l++;
                }

            }

            if (playedGames <= 0)
            {
                Console.WriteLine($"{teamName} hasn't played any games during this season.");
            }

            else
            {
                Console.WriteLine($"{teamName} has won {points} points during this season.");
                Console.WriteLine($"Total stats:");
                Console.WriteLine($"## W: {w}");
                Console.WriteLine($"## D: {d}");
                Console.WriteLine($"## L: {l}");
                winRate = (w / playedGames) * 100;
                Console.WriteLine($"Win rate: {winRate:f2}%");
            }

        }
    }
}
