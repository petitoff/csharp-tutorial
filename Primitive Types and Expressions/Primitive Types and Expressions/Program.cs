using System;

namespace Primitive_Types_and_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            VariablesAndConstants();
        }
        static void VariablesAndConstants()
        {
            // Variables and Constants

            byte number = 2;
            int count = 10;
            float totalPrice = 20.95F;
            char character = 'A';
            string firstName = "Mosh";
            bool isWorking = true;

            var numberV = 2;
            var countV = 10;
            var totalPriceV = 20.95F;
            var characterV = 'A';
            var firstNameV = "Mosh";
            var isWorkingV = true;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            Console.Write("Here: ");
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            const float Pi = 3.14f;
            // Pi = 1; // error
        }
    }
}
