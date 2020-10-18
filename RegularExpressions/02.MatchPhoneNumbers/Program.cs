using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _02.MatchPhoneNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string pattern = @"\+[3-9]{3}( |-)[2]{1}\1[\d]{3}\1[\d]{4}\b";

            MatchCollection realNumbers = Regex.Matches(numbers, pattern);

            var arr = realNumbers.Cast<Match>().Select(m => m.Value).ToArray();

            Console.WriteLine(String.Join(", ", arr));
      

        }
    }
}
