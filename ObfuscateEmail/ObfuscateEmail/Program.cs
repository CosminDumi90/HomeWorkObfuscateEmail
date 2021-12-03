using System;

namespace ObfuscateEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInput();
            
        }

        static void UserInput()
        {
            Console.WriteLine("Please enter your e-mail adress. Exemple: someone@yahoo.com:");
            string input = Console.ReadLine();
            IsEmailValid(input);
        }

        static void IsEmailValid(string input)
        {
            if (input.Contains("@"))
            {
                Console.WriteLine("email is ok");
                Obfuscate(input);
                return;
            }
            else
                Console.WriteLine("email is not ok");
            UserInput();

        }


        static void Obfuscate(string email)
        {

            var domainBorder = email.IndexOf('@');
            string username = email.Substring(0, domainBorder);//gets everthing starting from 0 index to the @
            string domain = email.Substring(email.IndexOf('@'));//gets everything after the @ symbol
            var hiddenEmail = new String('*', domainBorder);//(char c, int count)
            Console.WriteLine($"obfuscated email looks like this: {hiddenEmail + domain}");
        }
    }
}
