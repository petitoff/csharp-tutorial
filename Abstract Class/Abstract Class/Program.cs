﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = {new Circle(5), new Rectangle(4, 5)};

            foreach (Shape s in shapes)
            {
                s.GetInfo();
                Console.WriteLine("{0} Area : {1:f2}", s.Name, s.Area());

                Circle testCircle = s as Circle;
                if (testCircle == null)
                {
                    Console.WriteLine("This isn't a Circle");
                }

                if (s is Circle)
                {
                    Console.WriteLine("This isn't a Rectangle");
                }

                Console.WriteLine();

                object circ1 = new Circle(4);
                Circle circ2 = (Circle) circ1;
                Console.WriteLine("The {0} Area is {1:f2}", circ2.Name, circ2.Area());
            }
        }
    }
}
