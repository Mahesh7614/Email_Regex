namespace Email_Regex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Email in format: 'abc.xyz@bridgelabz.co.in' \n" +
                "where .xyz = number,Captital letters,small letters,+,-,_,. \n" +
                "where in = country code \n");
            Console.Write("Enter Email : ");
            string email = Console.ReadLine();
            Regex_Pattern.Pattern(email);
        }
    }
}