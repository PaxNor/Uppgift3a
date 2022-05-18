using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Uppgift 3.3
 * 
 *  Fråga 13: Man bör lägga ett nytt fågelattribut i Bird. Då ärver alla subklasser det attributet.
 *  Fråga 14: Då skulle man lägga det i den abstrakta bas klassen Animal för att ge alla subklasser det attributet.
 *  
 */


namespace Uppgift3a
{
    // IPerson interface
    internal interface IPerson
    {
        public string Talk();
    }

    // Abstract base class 
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
        public abstract string Stats();
    }

    // Animal sub classes
    internal class Horse : Animal
    {
        public Horse(string name, double weight, int age) : base(name, weight, age) { }

        public override string DoSound()
        {
            return "Neigh";
        }

        public string EatHay()
        {
            return "Eating";
        }
    }

    internal class Dog : Animal
    {
        private enum Posture { Sitting, Standing }

        private Posture posture;
        public Dog(string name, double weight, int age) : base(name, weight, age) 
        {
            posture = Posture.Sitting;
        }

        public override string DoSound()
        {
            return "Woof";
        }

        public void Sit()
        {
            posture = Posture.Sitting;
        }

        public void Stand()
        {
            posture = Posture.Standing;
        }
    }

    internal class Hedgehog : Animal
    {
        public int SpikeNumber { set; get; }
        public Hedgehog(string name, double weight, int age) : base(name, weight, age) { }

        public override string DoSound()
        {
            return "Hedgehog sound";
        }

    }

    internal class Worm : Animal
    {
        public int Length { set; get; }
        public Worm(string name, double weight, int age) : base(name, weight, age) { }

        public override string DoSound()
        {
            return "Worm sound";
        }
    }

    internal class Bird : Animal
    {
        public int WingSpan { set; get; }
        public Bird(string name, double weight, int age) : base(name, weight, age) { }

        public override string DoSound()
        {
            return "Squeek";
        }
    }

    internal class Wolf : Animal
    {
        public string FurColor { set; get; }
        public Wolf(string name, double weight, int age) : base(name, weight, age) { }

        public override string DoSound()
        {
            return "Houl";
        }
    }

    // Bird sub classes
    internal class Pelican : Bird
    {
        public Pelican(string name, double weight, int age) : base(name, weight, age) { }

        public override string DoSound()
        {
            return "Pelican sound";
        }
    }

    internal class Flamingo : Bird
    {
        public Flamingo(string name, double weight, int age) : base(name, weight, age) { }

        public override string DoSound()
        {
            return "Flamingo sound";
        }
    }

    internal class Swan : Bird
    {
        public Swan(string name, double weight, int age) : base(name, weight, age) { }

        public override string DoSound()
        {
            return "Swan sound";
        }
    }

    // inherits from wolf, implements IPerson
    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, double weight, int age) : base(name, weight, age) { }

        public override string DoSound()
        {
            return "Houl";
        }

        public string Talk()
        {
            return "I'm a wolfman";
        }
    }
}
