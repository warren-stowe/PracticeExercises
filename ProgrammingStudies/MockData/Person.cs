using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingStudies.MockData
{
    public class Person
    {
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

        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old and lives in {City}, {State}";
        }
    }
}
