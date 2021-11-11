using System;
using System.IO;

namespace HoroScope
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your star sign:");
            string starsign = Console.ReadLine();

            string output = GetLineFromFiledata(starsign);

            if (output.Length != 0)
            {
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Sorry. Color not found");
            }

        }

        private static string[] ReadDataFromFile()
        {
            string directoryPath = @"C:\Users\opilane\samples";
            string fileName = "personality.txt";
            string fullPath = $@"{directoryPath}\{fileName}";

            string[] dataFromFile = File.ReadAllLines(fullPath);
            return dataFromFile;
        }

        private static string GetLineFromFiledata(string userInput)
        {
            string[] dataFromFile = ReadDataFromFile();
            string result = "";

            foreach (string line in dataFromFile)
            {
                if (line.Contains(userInput))
                {
                    result = line;
                    break;
                }



            }
            return result;
        }
    }
}