using System;
using System.Text.RegularExpressions;

namespace BIO_1
{
    class Program
    {
        private static string[] symbolsMeanContainsCG =new string[] { "C", "G", "S", "W" };
        static void Main(string[] args)
        {
            string input,perctentage;
            Console.WriteLine("Enter DNA sequence:");
            input = Console.ReadLine();
            perctentage = cgContentsPercentage(input.ToUpper());
            Console.WriteLine("\nCG - contents: " + perctentage +"%");
        }

        static private int countCGContents(string input)
        {
            int cgMatches = 0;
            foreach (string symbol in symbolsMeanContainsCG)
            {
                MatchCollection matches = Regex.Matches(input, symbol);
                cgMatches += matches.Count;
            }
            return cgMatches;
        }

        static private string cgContentsPercentage(string input)
        {
            int cgMatches = countCGContents(input);
            return (Math.Round(((double)cgMatches / input.Length) * 100, 2)).ToString();
        }
    }
}
