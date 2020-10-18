using System;

namespace _13.Decrypt
{
    class Program
    {
        static void Main(string[] args)
        {

            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());

            string message = string.Empty;

            while (lines > 0)
            {

                message += ((char)(char.Parse(Console.ReadLine()) + key)).ToString();

                lines--;

            }

            Console.WriteLine(message);







//            You will receive a key(integer) and n characters afterward. Add the key to each of the characters and 
//                append them to a message. At the end print the message, which you decrypted. 
//Input
//•	On the first line, you will receive the key
//•	On the second line, you will receive n – the number of lines, which will follow
//•	On the next n lines – you will receive lower and uppercase characters from the Latin alphabet

        }
    }
}
