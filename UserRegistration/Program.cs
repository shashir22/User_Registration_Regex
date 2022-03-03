using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the user registration validation using c#");
            Patterns pattern = new Patterns();
            string[] FirstNames = { "Shashi", "Madhu", "Sohan" };
            string[] LastNames = { "Kumar", "Gowda", "Reddy" };
            String[] Emails = { "abc@gmail.com","abc1@co.in","abc@yahoo.com" }
            pattern.IsValidFirstName();
            pattern.IsValidLastName();
            pattern.IsValidEmail();
        }
    }
}