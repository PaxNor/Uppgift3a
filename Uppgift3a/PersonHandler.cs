using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3a
{
    internal class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public Person CreatePerson(int age, string fName, string lName, double height, double weight)
        {
            Person person = new Person(fName, lName);
            person.Age = age;
            person.Height = height;
            person.Weight = weight;

            return person;
        }

        public void SetPersonAge(Person person, int age)
        {
            person.Age = age;
        }

        public int GetPersonAge(Person person)
        {
            return person.Age;
        }

        public void ChangePersonFirstName(Person person, string newName)
        {
            person.FName = newName;
        }

        public string GetPersonFirstName(Person person)
        {
            return person.FName;
        }

        public void ChangePersonLastName(Person person, string newName)
        {
            person.LName = newName;
        }

        public string GetPersonLastName(Person person)
        {
            return person.LName;
        }

        public void ChangePersonWeight(Person person, double newWeight)
        {
            person.Weight = newWeight;
        }

        public double GetPersonWeight(Person person)
        {
            return person.Weight;
        }

        public void ChangePersonHeight(Person person, double newHeight)
        {
            person.Height = newHeight;
        }

        public double GetPersonHeight(Person person)
        {
            return person.Height;
        }
    }
}
