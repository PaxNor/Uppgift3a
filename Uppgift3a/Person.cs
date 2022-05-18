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

        public uint Age
        {
            get { return age; }
            set { age = value; }
        }

        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }

        public string LName
        {
            get { return lName; }
            set { lName = value; }
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




    }
}
