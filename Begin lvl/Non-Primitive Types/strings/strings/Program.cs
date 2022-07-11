using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string lastName = "to jest napis";
            string firstName = "to też jest napis";

            string name = string.Format("{0} {1}", firstName, lastName);
            Console.WriteLine(name);

            var numbers = new int[3] {1, 2, 3};
            string list = string.Join(",", numbers);
            Console.WriteLine(list);

            string nameO = "Mosh";
            char firstChar = nameO[0];
            //name[0] = "m"; // error
        }
    }
}
