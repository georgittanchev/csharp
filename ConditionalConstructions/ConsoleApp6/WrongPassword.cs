using System;
namespace _07.WrongPassword
{
    class WrongPassword
    {
        static void Main()
        {
            string password = Console.ReadLine();
            if (password == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome user");
                
            }
            else
            {
                Console.WriteLine("Fuck off");
            }
        }

    }
}
















//7. Познай паролата
//Да се напише програма, която чете парола(един ред с произволен текст), въведена от потребителя и
//проверява, дали въведеното съвпада с фразата &quot;s3cr3t!P @ssw0rd&quot;. При съвпадение да се изведе
//&quot;Welcome&quot;. При несъвпадение да се изведе &quot;Wrong password!&quot;.