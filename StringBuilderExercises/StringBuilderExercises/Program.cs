using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;


namespace StringBuilderExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] userNames = Console.ReadLine().Split(", ").ToArray();
     
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < userNames.Length; i++)
            {
                bool valid = true;
                if (userNames[i].Length < 3 || userNames[i].Length > 16)
                {
                    valid = false;
 
                }

                foreach (char item in userNames[i])
                {
                    if (!(char.IsLetterOrDigit(item) || item == '-' || item == '_'))
                    {
                        valid = false;
                  
                    }
                }

                if (valid == true)
                {
                    sb.AppendLine(userNames[i]);
                }

            }

     
            Console.WriteLine(sb);



//            Write a program that reads user names on a single line(joined by ", ") and prints all valid usernames.
//A valid username is:
//Has length between 3 and 16 characters
//Contains only letters, numbers, hyphens and underscores

        }
    }
}
