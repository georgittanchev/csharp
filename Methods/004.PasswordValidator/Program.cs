using System;
using System.Linq;

namespace _004.PasswordValidator
{

    class PasswordValidator
    {
        static void Main()
        {
            string password = Console.ReadLine();

            if (!isValidLenght(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isOnlyLettersAndChars(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!AtLeastTwoChars(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (AtLeastTwoChars(password) && isOnlyLettersAndChars(password) && isValidLenght(password))
            {
                Console.WriteLine("Password is valid");
            }

        }


        static bool isValidLenght (string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }

        static bool isOnlyLettersAndChars (string password)
        {

            foreach (char symbol in password)
            {

                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }
            }

            return true;
        }

        static bool AtLeastTwoChars (string password)
        {

            int counter = 0;

            foreach (char symbol in password)
            {
                if (char.IsDigit(symbol))
                {
                    counter++;
                }
            }

            if (counter >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}