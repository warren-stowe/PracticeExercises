using System;
using ProgrammingStudies.Basics;
using System.Collections.Generic;
using System.Linq;
using ProgrammingStudies.MockData;

namespace ProgrammingStudies
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Person> people = new Dictionary<int, Person>()
            {
                { 0, new Person("Warren", "Stowe", 35, "Pittsburgh", "PA", 1) },
                { 1, new Person("Ann", "Stowe", 34, "Pittsburgh", "PA", 2)  },
                { 2, new Person("Clyde", "Stowe", 68, "Cincinnati", "OH", 3)  },
                { 3, new Person("Willa", "Stowe", 1, "Pittsburgh", "PA", 4)  },
                { 4, new Person("Helga", "Alzner", 62, "Columbus", "OH", 5) },
                { 5, new Person("Andy", "Yurasek", 50, "Canal Winchester", "OH", 6) },
                { 6, new Person("Nerraw", "Ewots", 35, "Pittsburgh", "PA", 1) },
                { 7, new Person("Nna", "Ewots", 34, "Pittsburgh", "PA", 2)  },
                { 8, new Person("Edylc", "Ewots", 68, "Cincinnati", "OH", 3)  },
                { 9, new Person("Alliw", "Ewots", 1, "Pittsburgh", "PA", 4)  },
                { 10, new Person("Agleh", "Alzner", 62, "Columbus", "OH", 5) },
                { 11, new Person("Ydna", "Yurasek", 50, "Canal Winchester", "OH", 6) },
                { 12, new Person("Sara", "Stowe", 39, "Dayton", "OH", 7) },
                { 13, new Person("Alex", "Stowe", 16, "Dayton", "OH", 8) }
            };

            Person newGuy = new Person("Warren", "Stowe", 35, "Pittsburgh", "PA", 1);
            bool test = newGuy == people[0];
            Console.WriteLine(test);

            people.Add(14, new Person("Sean", "Rogers", 42, "Greentree", "PA", 9));
            Console.WriteLine("Removing " + people[5].FirstName);
            people.Remove(5);

            var query = from person in people
                        group person by person.Value.City into cityGroup
                        select cityGroup;

            foreach (var cityGroup in query)
            {
                foreach (var person in cityGroup)
                {

                    Console.WriteLine(person);
                }
            }

            Console.WriteLine("**** " + people[3].City);
            
            

        }

    }
}
