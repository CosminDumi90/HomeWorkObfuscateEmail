using System;

namespace ObfuscateEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = "cosmindumi20@yahoo.com";
            var domainBorder = email.IndexOf('@');
            string username= email.Substring(0, domainBorder);//gets everthing starting from 0 index to the @
            string domain = email.Substring(email.IndexOf('@'));//gets everything after the @ symbol
            var hiddenEmail = new String('*', domainBorder);//(char c, int count)
            Console.WriteLine($"obfuscated email looks like this: {hiddenEmail + domain}");
        }
    }
}
