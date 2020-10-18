using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads the path to a file and subtracts the file name and its extension.

            string[] path = Console.ReadLine().Split("\\").ToArray();
            string[] fileInfo = path.Last().Split(".").ToArray();
            List<string> fileNames = new List<string>();
            int counter = fileInfo.Count();
            string fileName = string.Empty;
            string fileExtension = string.Empty;
            if (counter < 3)
            {
               fileName = fileInfo[0];
               fileExtension = fileInfo[1];
            }
            else
            {
                for (int i = 0; i < counter - 1; i++)
                {
                    fileNames.Add(fileInfo[i]);
                }
                fileExtension = fileInfo[^1];
                fileName = string.Join(".", fileNames);
            }

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");

        }
    }
}
