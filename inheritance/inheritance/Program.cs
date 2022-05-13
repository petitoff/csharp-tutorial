﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        class Animal
        {
            public string name;
            public int age;
            public float happiness;

            public void PrintBase()
            {
                Console.WriteLine($"Name {name}");
                Console.WriteLine($"Age {age}");
                Console.WriteLine($"Happiness {happiness}");
            }
        }

        class Dog : Animal
        {
            public int spotCount;

            public void Bark()
            {
                Console.WriteLine("WUF!");
                base.happiness += 0.1f;
            }
        }

        class Cat : Animal
        {
            public float cuteness;

            public void Meow()
            {
                Console.WriteLine("MEOW!");
            }
        }

        static void Main(string[] args)
        {
            Dog spotty = new Dog();
            spotty.name = "Spotty";
            spotty.age = 4;
            spotty.happiness = 0.8f;
            spotty.spotCount = 25;
            spotty.PrintBase();
            spotty.Bark();
            Console.WriteLine($"New Hapiness {spotty.happiness}");

            Cat heisenberg = new Cat();
            heisenberg.name = "Heisenberg";
            heisenberg.age = 13;
            heisenberg.happiness = 0.3f;
            heisenberg.cuteness = 0;
            heisenberg.cuteness = 0.4f;
            heisenberg.PrintBase();
            heisenberg.Meow();
        }
    }
}
