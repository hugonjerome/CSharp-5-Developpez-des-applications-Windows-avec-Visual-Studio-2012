using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class Program
    {
        const string Original = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mio enim sapien, dignissim in eleifend mcc, molestie scr amet sapien. Proin in ligula 022-999, eget eleifend urna. Nunc sollicitudin elementum agr, ddu mattis arcu auctor mfi? Mauris vulputate condimentum venenatis. Curabitur semper faucibus arcu mpe sagittis.";

        static void Main(string[] args)
        {
            string pattern = "mio";
            MatchCollection matches = Regex.Matches(Original,
                                                    pattern,
                                                    RegexOptions.IgnoreCase);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Index);
            }

            Console.WriteLine("******************************************************");

            Console.WriteLine(Regex.Match(Original, @"mfi?"));
            Console.WriteLine(Regex.Match(Original, @"mfi\?"));

            Console.WriteLine("******************************************************");

            Console.WriteLine(Regex.Escape(@"?"));
            Console.WriteLine(Regex.Unescape(@"\?"));

            Console.WriteLine("******************************************************");

            Console.WriteLine(Regex.Match(Original, @"sc[Rr]"));
            Console.WriteLine(Regex.Match(Original, @"sc[^Rr]"));
            Console.WriteLine(Regex.Match(Original, @"sc[n-z]"));

            Console.WriteLine("******************************************************");

            Console.WriteLine(Regex.Match(Original, @"\d\D\d"));

            Console.WriteLine("******************************************************");

            Console.WriteLine(Regex.Match(Original, @"\w"));
            Console.WriteLine(Regex.Match(Original, @"[a-zA-Z0-9_]"));

            Console.WriteLine("******************************************************");

            Console.WriteLine(Regex.Match(Original, @"Lorem\sipsum"));

            Console.WriteLine("******************************************************");

            Console.WriteLine(Regex.Match(Original, @"m.e"));

            Console.WriteLine("******************************************************");

            Console.WriteLine(Regex.Match(Original, @"d\p{L}u"));

            Console.WriteLine("******************************************************");

            Match result = Regex.Match(Original, @"(\d\d\d)-(\d\d\d)");
            Console.WriteLine(result);
            Console.WriteLine(result.Groups[0]);
            Console.WriteLine(result.Groups[1]);
            Console.WriteLine(result.Groups[2]);

            Console.WriteLine("******************************************************");

            foreach (Match match in Regex.Matches(Original, @"(\w)\1"))
            {
                Console.WriteLine(match.Value);
            }

            Console.WriteLine("******************************************************");

            foreach (Match match in Regex.Matches(Original, @"(?'lettre'\w)\k<lettre>"))
            {
                Console.WriteLine(match.Value);
            }

            Console.WriteLine("******************************************************");

            Console.WriteLine(Regex.Match(Original, @"^\w"));

            Console.WriteLine("******************************************************");

            Console.WriteLine(Regex.Match(Original, @"(\d{3})-(\d{3})"));

            Console.ReadLine();
        }
    }
}
