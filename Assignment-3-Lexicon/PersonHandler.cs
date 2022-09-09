using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_Lexicon
{
    class PersonHandler
    {
        public void SetAge(Person person, int age)
        {
            person.Age = age;
        }

        public static Person CreatePerson(int age, string fName, string lName, double height, double weight)
        {
            Person person = new Person
            {
                Age = age,
                FName = fName,
                LName = lName,
                Height = height,
                Weight = weight
            };

            return person;
        }
    }
}
