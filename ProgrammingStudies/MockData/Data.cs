using System;
using System.Collections.Generic;

namespace ProgrammingStudies.MockData
{

    public static class Data
    {

        public static List<Person> ListOfPeople { get; set; } = new List<Person>()
        {
            { new Person("Warren", "Stowe", 35, "Pittsburgh", "PA", 1) },
            { new Person("Ann", "Stowe", 34, "Pittsburgh", "PA", 2)  },
            { new Person("Clyde", "Stowe", 68, "Cincinnati", "OH", 3)  },
            { new Person("Willa", "Stowe", 1, "Pittsburgh", "PA", 4)  },
            { new Person("Helga", "Alzner", 62, "Columbus", "OH", 5) },
            { new Person("Andy", "Yurasek", 50, "Canal Winchester", "OH", 6) },
            { new Person("Nerraw", "Ewots", 35, "Pittsburgh", "PA", 7) },
            { new Person("Nna", "Ewots", 34, "Pittsburgh", "PA", 8)  },
            { new Person("Edylc", "Ewots", 68, "Cincinnati", "OH", 9)  },
            { new Person("Alliw", "Ewots", 1, "Pittsburgh", "PA", 10)  },
            { new Person("Agleh", "Alzner", 62, "Columbus", "OH", 11) },
            { new Person("Ydna", "Yurasek", 50, "Canal Winchester", "OH", 12) },
            { new Person("Sara", "Stowe", 39, "Dayton", "OH", 13) },
            { new Person("Alex", "Stowe", 16, "Dayton", "OH", 14) },
            { new Person("Jared", "Cox", 39, "Imperial", "PA", 15) },
            { new Person("Andrea", "Cox", 38, "Imperial", "PA", 16) },
            { new Person("Brandon", "Hinerman", 36, "Pataskala", "OH", 17) }
        };


    }
}