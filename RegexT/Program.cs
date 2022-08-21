using System;
using System.IO;
using System.Text.RegularExpressions;

namespace RegexT
{
    class Program
    {
        static void Main(string[] args)
        {
            MyRegex();
        }

        static void MyRegex()
        {
            Regex regex = new Regex(@"\+?(61|0)\d(( |)\d{4}( |)\d{4}|\d{2}( |)\d{3}( |)\d{3})"); // aus phone numbers

            string text = File.ReadAllText(@"C:\Users\josht\Downloads\RegexT\RegexT\RegexT\Sample.txt");

            MatchCollection matches = regex.Matches(text);

            Console.WriteLine("Found {0} matches in the text file", matches.Count);

            Console.WriteLine("Matches:");

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }

        static void OriginalRegex()
        {
            // defining a regular expression with a pattern
            Regex regex = new Regex(@"\d");



            // Test string
            string text = "Hi there 123";

            // Find hits
            MatchCollection hits = regex.Matches(text);

            // Anzahl der Treffer
            Console.WriteLine("{0} hits found:\n   {1}",
                hits.Count,
                text);

            // amount of hits
            foreach (Match aHit in hits)
            {
                GroupCollection groups = aHit.Groups;
                Console.WriteLine("'{0}' found at {1}",
                    groups["word"].Value,
                    groups[0].Index
                );
            }
            Console.ReadLine();
        }
    }
}
