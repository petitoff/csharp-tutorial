using System;

namespace Primitive_Types_and_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //VariablesAndConstants();
            //TypeConversion();
            Operators();
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

        static void TypeConversion()
        {
            // Type Conversion

            byte a = 1;
            int b = a;
            Console.WriteLine($"{a} {b}");

            int c = 1;
            //byte d = c; // won't compile
            byte d = (byte)c;

            string s = "1";
            int i = Convert.ToInt32(s);
            int j = int.Parse(s);

            // Demo: Type Conversion
            try
            {
                var number = "1234";
                byte byteNumber = Convert.ToByte(number);
                Console.WriteLine(byteNumber);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }
        }

        static void Operators()
        {
            var a = 10;
            var b = 3;
            var c = 7;

            Console.WriteLine(a / b);
            Console.WriteLine((float)a / b);
            Console.WriteLine((a + b) * c);

            Console.WriteLine(a > b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);

            // This is same
            Console.WriteLine(!(a != b));
            Console.WriteLine(a == b); // but this is better

            Console.WriteLine("\nSection && and ||");
            Console.WriteLine(c > b && a > c);

            Console.WriteLine(c > b && c > a);
            Console.WriteLine(c > b || c > a);

            Console.WriteLine(!(c > b && c > a));
        }

        static void Comments()
        {
            // Here is a single-line comment

            /*
             * Here is a multi-line
             * comment
             */

            // or like this
            // multi-line
            // comment with only "//"
        }
    }
}
