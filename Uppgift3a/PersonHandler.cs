using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3a
{
    internal class PersonHandler
    {
        public void SetAge(Person pers, uint age)
        {
            pers.Age = age;
        }

        public Person CreatePerson(uint age, string fName, string lName, double height, double weight)
        {
            Person person = new Person(fName, lName);
            person.Age = age;
            person.Height = height;
            person.Weight = weight;

            return person;
        }
    }
}
