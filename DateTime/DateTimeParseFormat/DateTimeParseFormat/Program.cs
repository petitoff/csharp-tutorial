using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeParseFormat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mainDate = "10.7.2022";
            DateTime dateString = DateTime.Parse(mainDate);

            Console.WriteLine(dateString);
        }
    }
}
