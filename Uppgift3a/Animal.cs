﻿using System;
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

        public Animal(string name, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        public abstract string DoSound();
    }

    internal class Horse : Animal
    {
        public Horse(string name, double weight, int age) : base(name, weight, age) { }

        public override string DoSound()
        {
            return "Neigh";
        }
    }

    internal class Dog : Animal
    {
        public Dog(string name, double weight, int age) : base(name, weight, age) { }

        public override string DoSound()
        {
            return "Woof";
        }
    }

    internal class Hedgehog : Animal
    {
        public Hedgehog(string name, double weight, int age) : base(name, weight, age) { }

        public override string DoSound()
        {
            return "Hedgehog sound";
        }

    }

    internal class Worm : Animal
    {
        public Worm(string name, double weight, int age) : base(name, weight, age) { }

        public override string DoSound()
        {
            return "Worm sound";
        }
    }

    internal class Bird : Animal
    {
        public Bird(string name, double weight, int age) : base(name, weight, age) { }

        public override string DoSound()
        {
            return "Squeek";
        }
    }

    internal class Wolf : Animal
    {
        public Wolf(string name, double weight, int age) : base(name, weight, age) { }

        public override string DoSound()
        {
            return "Houl";
        }
    }
}
