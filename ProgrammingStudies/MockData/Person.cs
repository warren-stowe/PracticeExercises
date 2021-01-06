using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingStudies.MockData
{
    public class Person
    {
        // Dummy class to be used in other practice classes

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Id { get; set; }

        public Person(string fName, string lName, int age, string city, string state, int id)
        {
            FirstName = fName;
            LastName = lName;
            Age = age;
            City = city;
            State = state;
            Id = id;
        }

        /// <summary>
        /// Random Person constructor.
        /// </summary>
        public Person()
        {
            Random random = new Random();

            string[] firstNames = new string[] {"Ann", "Brandon", "Carl", "Donovan", "Erika", "Fred", "Gary", "Helga", "Inge", "Jessica", "Karen", "Liam", "Marvin", "Nancy", "Oscar",
            "Penelope", "Quentin", "Ronald", "Sara", "Tom", "Ulysses", "Virginia", "Warner", "Xavier", "Yvonne", "Zack" };

            string[] lastNames = new string[] {"Allen", "Boskowitz", "Connor", "Dandarion", "Eloute", "Frederick", "Gregory", "Hanover", "Isaac", "Jackson", "Klemens", "Lopez",
            "Marron", "Novitzski", "Opune", "Paulson", "Quintz", "Reagan", "Slack", "Toritz", "Ulin", "Veront", "Warren", "Yslozovitz", "Zarmun"};

            string[] cities = new string[] { "Columbus", "Dayton", "Cincinatti", "Cleveland", "New York", "Pittsburgh", "Philadelphia", "San Francisco", "Denver" };

            FirstName = firstNames[random.Next(0, firstNames.Length - 1)];
            LastName = lastNames[random.Next(0, lastNames.Length - 1)];
            Age = random.Next(0, 100);
            City = cities[random.Next(0, cities.Length - 1)];
            State = "USA";

            Id = random.Next(0, 1000000);

        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old and lives in {City}, {State}";
        }

        public void Walk()
        {
            Console.WriteLine($"{FirstName} is walking.");
        }


    }
}
