using System;
using System.Text.RegularExpressions;


namespace Email_Regex
{
    internal class Regex_Pattern
    {
        public static void Pattern(string pattern)
        {
            Regex code = new Regex(@"(abc)");
            bool matches = code.IsMatch(pattern);

            if (matches == true)
            {
                Console.WriteLine("Email is Valid");
            }
            else
            {
                Console.WriteLine("Please Enter Valid Email");
            }
        }
    }
}
