using System;
using System.Text.RegularExpressions;


namespace Email_Regex
{
    internal class Regex_Pattern
    {
        public static void Pattern(string pattern)
        {
            Regex email = new Regex(@"(abc)[a-zA-Z0-9_\\+\-\\.]*[@](bridgelabz)*[.](co)*[.]");
            bool matches = email.IsMatch(pattern);

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
