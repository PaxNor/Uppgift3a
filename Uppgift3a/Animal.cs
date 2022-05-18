using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3a
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public string Sound { private get; set; }

        public Animal(string name, double weight, int age, string sound)
        {
            Name = name;
            Weight = weight;
            Age = age;
            Sound = sound;
        }

        public string DoSound()
        {
            return Sound;
        }
    }
}
