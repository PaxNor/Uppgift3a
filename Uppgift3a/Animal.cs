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
 * Uppgift 3.4
 * 
 *  Fråga 9: En häst är inte en subklass till hund.
 *  Fråga 10: Animal
 *  Fråga 13: Rätt metod anropas p.g.a polymorfism, varje objekt i listan ärver från Animal och överlagrar Stats() metoden.
 *  Fråga 17: Det fungerar om man först kontrolerar att djuret är en hund och sedan castar Animal objektet till Dog.
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
        public virtual string Stats() {
            return $"{Name}, {Weight}, {Age}";
        }

    }

    // Animal sub classes
    internal class Horse : Animal
    {
        private const string sound = "Neigh";
        public Horse(string name, double weight, int age) : base(name, weight, age) { }

        public override string DoSound()
        {
            return sound;
        }

        public string EatHay()
        {
            return "Eating";
        }

        public override string Stats()
        {
            return $"{Name}, {Weight}, {Age}, {sound}";
        }
    }

    internal class Dog : Animal
    {
        private enum Posture { Sitting, Standing }

        private const string sound = "Woof";
        private Posture posture;
        public Dog(string name, double weight, int age) : base(name, weight, age) 
        {
            posture = Posture.Sitting;
        }

        public override string DoSound()
        {
            return sound;
        }

        public void Sit()
        {
            posture = Posture.Sitting;
        }

        public void Stand()
        {
            posture = Posture.Standing;
        }

        public override string Stats()
        {
            return $"{Name}, {Weight}, {Age}, {sound}, {posture.ToString()}";
        }

        public string GetPosture()
        {
            return posture.ToString();
        }
    }

    internal class Hedgehog : Animal
    {
        private const string sound = "Hedgehog sound";
        public int SpikeNumber { set; get; }
        public Hedgehog(string name, double weight, int age, int spikeNumber) : base(name, weight, age) 
        { 
            SpikeNumber = spikeNumber;
        }

        public override string DoSound()
        {
            return sound;
        }

        public override string Stats()
        {
            return $"{Name}, {Weight}, {Age}, {sound}, {SpikeNumber}";
        }
    }

    internal class Worm : Animal
    {
        private const string sound = "Worm sound";
        public int Length { set; get; }
        public Worm(string name, double weight, int age, int length) : base(name, weight, age) 
        {
            Length = length;
        }

        public override string DoSound()
        {
            return sound;
        }

        public override string Stats()
        {
            return $"{Name}, {Weight}, {Age}, {sound}, {Length}";
        }
    }

    internal class Bird : Animal
    {
        private const string sound = "Squeek";
        public int WingSpan { set; get; }
        public Bird(string name, double weight, int age, int wingSpan) : base(name, weight, age) 
        {
            WingSpan = wingSpan;
        }

        public override string DoSound()
        {
            return sound;
        }

        public override string Stats()
        {
            return $"{Name}, {Weight}, {Age}, {sound}, {WingSpan}";
        }
    }

    internal class Wolf : Animal
    {
        private const string sound = "Houl";
        public string FurColor { set; get; }
        public Wolf(string name, double weight, int age, string furColor) : base(name, weight, age) 
        {
            FurColor = furColor;
        }

        public override string DoSound()
        {
            return sound;
        }

        public override string Stats()
        {
            return $"{Name}, {Weight}, {Age}, {sound}, {FurColor}";
        }
    }

    // Bird sub classes
    internal class Pelican : Bird
    {
        public Pelican(string name, double weight, int age, int wingSpan) : base(name, weight, age, wingSpan) { }

        public override string DoSound()
        {
            return "Pelican sound";
        }
    }

    internal class Flamingo : Bird
    {
        public Flamingo(string name, double weight, int age, int wingSpan) : base(name, weight, age, wingSpan) { }

        public override string DoSound()
        {
            return "Flamingo sound";
        }
    }

    internal class Swan : Bird
    {
        public Swan(string name, double weight, int age, int wingSpan) : base(name, weight, age, wingSpan) { }

        public override string DoSound()
        {
            return "Swan sound";
        }
    }

    // inherits from wolf, implements IPerson
    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, double weight, int age, string furColor) : base(name, weight, age, furColor) { }

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
