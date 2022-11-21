namespace Email_Regex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Email ID : ");
            string email = Console.ReadLine();
            Regex_Pattern.Pattern(email);
        }
    }
}