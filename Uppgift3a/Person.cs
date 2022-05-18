using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3a
{
    internal class Person
    {
        private uint age;
        private string fName;
        private string lName;
        private uint height;
        private uint weight;

        public uint Age {
            get { return age; }
            set {
                if(value < 0) {
                    throw new ArgumentException("Age must be greater than 0");
                }
                age = value;
            }
        }

        public string FName
        {
            get { return fName; }
            set { 
                if(value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException("First name must be between 2 - 10 characters long.");
                }
                fName = value;
            }
        }

        public string LName
        {
            get { return lName; }
            set { 
                if(value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("Last name must be between 3 - 15 characters long.");
                }
                lName = value;
            }
        }

        public uint Height
        {
            get { return height; }
            set { height = value; }
        }

        public uint Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public Person(string fName, string lName)
        {
            // setting value with properties which includes a range check!
            FName = fName;
            LName = lName;
        }



    }
}
