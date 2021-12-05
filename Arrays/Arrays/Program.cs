using System;

namespace DrawHeart
{
    class Draw_a_Heart
    {
        static void Main()
        {
            Console.Title = "Draw a Heart";


        Again:
            try
            {
            Play:
                Console.Write("Enter number: ");
                int n = int.Parse(Console.ReadLine());
                if (n <= 2 || n > 35)
                {
                    Console.WriteLine("Number must be between 3...35");
                    goto Play;
                }

                int spacesNum = (int)Math.Floor(n / 2.0);
                int hashesNum = 3;
                int midSpacesNum = n;
                char hashes = '#';
                char spaces = ' ';
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine();
                for (int i = 0; spacesNum >= 0; i++)
                {

                    Console.WriteLine(new string(spaces, spacesNum) + new string(hashes, hashesNum) + new string(spaces, midSpacesNum) + new string(hashes, hashesNum) + new string(spaces, spacesNum));
                    hashesNum += 2;
                    midSpacesNum -= 2;
                    spacesNum--;
                }
                for (int i = 0; i < Math.Floor(n / 2.0); i++)
                {
                    Console.WriteLine(new string(hashes, 2 * (int)Math.Floor(n / 2.0) + n + 6));
                }
                hashesNum = 2 * (int)Math.Floor(n / 2.0) + n + 4;
                spacesNum = 1;
                for (int i = 0; i < n + 2; i++)
                {
                    Console.WriteLine(new string(spaces, spacesNum) + new string(hashes, hashesNum) + new string(spaces, spacesNum));
                    spacesNum++;
                    hashesNum -= 2;
                }
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine();

            Q:
                Console.Write("Do you want to continue? (Y/N) : ");

                string contin = Console.ReadLine().ToLower();
                if (contin == "y" || contin == "yes" || contin == "")
                {
                    Console.Clear();
                    goto Play;
                }
                else if (contin == "n" || contin == "no")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Answer properly");
                    goto Q;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number !");
                goto Again;
            }


        }
    }
}