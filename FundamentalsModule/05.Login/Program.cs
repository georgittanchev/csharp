using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {


            string username = Console.ReadLine();
            string password = string.Empty;
            string passwordTest = string.Empty;
            int counter = 0;


            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            while (counter <= 3)
            {

                passwordTest = Console.ReadLine();
                counter++;
                if (counter == 4 && passwordTest != password)
                {
                    Console.WriteLine($"User {username} blocked!");
                }
                else if (passwordTest != password)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                else
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                
            }
        }
    }
}
