using System;

namespace Demo_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Mosh";
            var lastName = "Hamedani";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] {"Jonas", "Jack", "Mary"};
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            var text = @"Hi John
Look into the following path
c:\folder1\folder2\folder3\folder4";
            Console.WriteLine(text);
        }
    }
}
