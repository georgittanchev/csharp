using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.FancyBarCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<beginner>@#+)(?<message>[A-Z][a-zA-Z0-9]{4,}[A-Z])(?<ender>@#+)";
            int numberOfBarcodes = int.Parse(Console.ReadLine());
            string barCode = string.Empty;
            string finalNumber = string.Empty;
            int counter = 0;
            for (int i = 0; i < numberOfBarcodes; i++)
            {
                barCode = Console.ReadLine();
                Match barcodeMatch = Regex.Match(barCode, pattern);
                if (barcodeMatch.Success)
                {
                    string barcodeNumber = "00";
                    for (int o = 0; o < barcodeMatch.Value.Length; o++)
                    {
                        char theChar = barcodeMatch.Value[o];
                        if (char.IsDigit(theChar))
                        {
                            barcodeNumber = theChar.ToString();
                            finalNumber += barcodeNumber;
                            counter++;
                        }
                    }
                    if (counter > 0)
                    {
                        Console.WriteLine($"Product group: {finalNumber}");
                        finalNumber = string.Empty;
                        counter = 0;
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {barcodeNumber}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
