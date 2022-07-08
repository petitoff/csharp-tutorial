using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatoryDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int kosmetyk1 = 15;
            int kosmetyk2 = 30;

            Shape shape1 = new Shape(kosmetyk1);
            Shape shape2 = new Shape(kosmetyk2);
            Shape shape3 = new Shape();

            shape3 = shape1 + shape2;

            //shape3 = shape1 == shape2;

            Console.WriteLine(shape3.a);
        }
    }
}
