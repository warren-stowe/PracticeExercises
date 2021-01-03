using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingStudies.Basics
{
    public class PropsAnswers
    {
        // Implement a Field
        private string fullName;
        private string firstName;
        private string lastName;
        private string alias;
        private int age;

        public PropsAnswers(string alias, int age)
        {
            this.alias = alias;
            this.Age = age;
        }

        public string Alias { get; }

        // Implement a Read-Only Property, initialize with a property initializer
        public int Age { get; }
        // Implement a Property using an Expression Body
        // Implement a Validation Property
        public string FirstName
        {
            get => firstName;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    firstName = value;
                    fullName = null;
                }
            }
        }

        // Implement a Property with a Ternary Operator that validates input and throws an exception on failure
        public string LastName
        {
            get => lastName;
            set { lastName = (!string.IsNullOrWhiteSpace(value)) ? value : throw new ArgumentException("Invalid input (null or white space)"); }
            // OR
            // set => lastName = (!string.IsNullOrWhiteSpace(value)) ? value : throw new ArgumentException("Invalid input (null or white space)"); 
        }

        // Implement a Computed Property
        // Implement a Computed Property with an Expression Body
        public string NameWithAlias
        {
            get => $"{firstName} \"{alias}\" {lastName}";
        }

        // Implement a Cached Evaluated Property
        public string FullName
        {
            get
            {
                if (fullName == null)
                {
                    fullName = $"{firstName} {lastName}";
                }

                return fullName;
            }
        }

        public int Weight { get; set; }

    }
}

