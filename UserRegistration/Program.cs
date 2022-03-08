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
            String[] Emails = { "abc@gmail.com", "abc1@co.in", "abc@yahoo.com" };
            string[] Nunber = { "8884540867", "8660907461", "9964411161" };
            string[] Password = { "Shashi@123", "Madhu@456", "Sohan1212" };
            pattern.IsValidFirstName();
            pattern.IsValidLastName();
            pattern.IsValidEmail();
            pattern.IsValidPhoneNo();
            pattern.IsValidPasswordRule1();
        }
    }
}
