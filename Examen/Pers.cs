using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Pers
    {
        public  string FirstName { get; set; }
        public  string LastName { get; set; }
        public int YearOfBirth { get; set; }

        public int Age
        {
            get { return DateTime.Now.Year - YearOfBirth; }
        }

        static class PersonProcessor
        {
            public static Person GetOldestPerson(Person[] people)
            {
                Person oldestPerson = people[0];
                foreach (Person person in people)
                {
                    if (person.Age > oldestPerson.Age)
                    {
                        oldestPerson = person;
                    }
                }
                return oldestPerson;
            }

        }
       
    }
}
