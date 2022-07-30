using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfInts = new List<int>
            {
                3,7,8,11,2,1
            };

            var listOfStrings = new List<string>
            {
                "Ala",
                "Ma",
                "Dużego",
                "Kota",
                "I",
                "",
                "Samochód"
            };

            var listOfUsers = new List<User>
            {
                new User
                {
                    FirstName = "Błażej",
                    LastName = "Domagała",
                    Email = "petitoff@outlook.com"
                },
                new User
                {
                    FirstName = "Maciek",
                    LastName = "Fajny",
                    Email = "petitoff@outlook.com"
                },
                new User
                {
                    FirstName = "Piotr",
                    Email = "innymail@outlook.com"
                },
                null
            };

            var list1 = listOfInts.Select(x => x + 5).ToList();

            var listOfLastNameUsers = listOfUsers.Where(u => u != null && !string.IsNullOrEmpty(u.LastName)).ToList();
            listOfLastNameUsers.ForEach(x =>
            {
                Console.WriteLine($"{x.FirstName} {x.LastName}");
            });

            var user = listOfUsers.Where(u => u != null && !string.IsNullOrEmpty(u.LastName)).FirstOrDefault();

            if (user != null)
            {
                Console.WriteLine($"{user.FirstName} {user.LastName} and have {user.Email}");
            }

            var strings = listOfStrings.OrderByDescending(x => x).ToList();

            listOfUsers.Where(x => x != null).GroupBy(x => x.Email).ToList().ForEach(x =>
            {
                Console.WriteLine(x.Key);

                x.ToList().ForEach(y =>
                {
                    Console.WriteLine(y.FirstName);
                });
            });
        }
    }
}