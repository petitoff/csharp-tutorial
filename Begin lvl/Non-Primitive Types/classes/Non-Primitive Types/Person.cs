using System;

namespace Non_Primitive_Types
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine($"My name is {FirstName} {LastName}");
        }
    }
}
