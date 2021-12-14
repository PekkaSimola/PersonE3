using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonE3
{
    /// <summary>
    /// Base-class for this file is Animal
    /// </summary>
    internal abstract class Animal
    {

        public string Name { get; set; }
        public double Weight { get; set; }
        public double Age { get; set; }

        public Animal(string name, double weight, double age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        public abstract void DoSound();

        public virtual string Stats() => $"Name: {Name}\n\t • Weight: {Weight} kg; Age: {Age} years";

    }

    internal class Horse : Animal
    {
        public string Color { get; set; }

        public Horse(string name, double weight, double age, string color) : base(name, weight, age)
        {
            Color = color;
        }

        public override void DoSound()
        {
            Console.WriteLine("Horse is heighing.");
        }

        public override string Stats() => $"Name: {Name}\n\t • Weight: {Weight} kg; Age: {Age} years; Color: {Color}";
    }

    internal class Hedgehog : Animal
    {
        public int NrOfSpikes { get; set; }

        public Hedgehog(string name, double weight, double age, int nrOfSpikes) : base(name, weight, age)
        {
            NrOfSpikes = nrOfSpikes;
        }

        public override void DoSound()
        {
            Console.WriteLine("Hedgehog is grunting.");
        }

        public override string Stats() => $"Name: {Name}\n\t • Weight: {Weight} kg; Age: {Age} years; NrOfSpikes: {NrOfSpikes}";
    }

    internal class Worm : Animal
    {
        public bool IsPoisonous { get; set; }

        public Worm(string name, double weight, double age, bool isPoisonous) : base(name, weight, age)
        {
            IsPoisonous = isPoisonous;
        }

        public override void DoSound()
        {
            Console.WriteLine("Worm is fizzling.");
        }

        public override string Stats() => $"Name: {Name}\n\t • Weight: {Weight} kg; Age: {Age} years; IsPoisonous: {IsPoisonous}";
    }

    internal class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string name, double weight, double age, string breed) : base(name, weight, age)
        {
            Breed = breed;
        }

        public override void DoSound()
        {
            Console.WriteLine("Dog is barking.");
        }

        public static string Woozy() => $"Ohh... I feel woozy...";

        public override string Stats() => $"Name: {Name}\n\t • Weight: {Weight} kg; Age: {Age} years; Breed: {Breed}";
    }

    internal class Wolf : Animal
    {
        public string Color { get; set; }

        public Wolf(string name, double weight, double age, string color) : base(name, weight, age)
        {
            Color = color;
        }

        public override void DoSound()
        {
            Console.WriteLine("Wolf is growling.");
        }

        public override string Stats() => $"Name: {Name}\n\t • Weight: {Weight} kg; Age: {Age} years; Color: {Color}";
    }

    /// <summary>
    /// Classes related to Bird-type of animals.
    /// Base-class is Bird
    /// </summary>
    internal class Bird : Animal
    {
        public double WingSpan { get; set; }

        public Bird(string name, double weight, double age, double wingSpan) : base(name, weight, age)
        {
            WingSpan = wingSpan;
        }

        public override void DoSound()
        {
            Console.WriteLine("Bird is singing.");
        }

        public override string Stats() => $"Name: {Name}\n\t • Weight: {Weight} kg; Age: {Age} years; WingSpan: {WingSpan} cm";
    }

    internal class Pelican : Bird
    {
        public string Color { get; set; }

        public Pelican(string name, double weight, double age, double wingSpan, string color) : base(name, weight, age, wingSpan)
        {
            Color = color;
        }

        public override void DoSound()
        {
            Console.WriteLine("Pelican is shrilling.");
        }

        public override string Stats() => $"Name: {Name}\n\t • Weight: {Weight} kg; Age: {Age} years; WingSpan: {WingSpan} cm; Color: {Color}";
    }

    internal class Flamingo : Bird
    {
        public string Color { get; set; }

        public Flamingo(string name, double weight, double age, double wingSpan, string color) : base(name, weight, age, wingSpan)
        {
            Color = color;
        }

        public override void DoSound()
        {
            Console.WriteLine("Flamingo is honking.");
        }

        public override string Stats() => $"Name: {Name}\n\t • Weight: {Weight} kg; Age: {Age} years; WingSpan: {WingSpan} cm; Color: {Color}";
    }

    internal class Swan : Bird
    {
        public string Color { get; set; }

        public Swan(string name, double weight, double age, double wingSpan, string color) : base(name, weight, age, wingSpan)
        {
            Color = color;
        }

        public override void DoSound()
        {
            Console.WriteLine("Swan is trumpeting.");
        }

        public override string Stats() => $"Name: {Name}\n\t • Weight: {Weight} kg; Age: {Age} years; WingSpan: {WingSpan} cm; Color: {Color}";
    }

    internal class Wolfman : Wolf, IPerson
    {
        public double SnoutLength { get; set; }

        public Wolfman(string name, double weight, double age, string color, double snoutLength) : base(name, weight, age, color)
        { 
            SnoutLength = snoutLength;
        }

        public override void DoSound()
        {
            Console.WriteLine("Wolfman is grunting.");
        }

        /*
         * Calling As Follows:
         * 1) Wolfman w = new(parameter-list);
         * •  Observe that w.Talk() won't work!
         * 2) IPerson ip = w;
         * •  We need a ref of IPerson type pointing at the wolfman object.
         * 3) ip.Talk();
         * •  This works because ip points at the object containing the implementation of the Talk() method.
         *    Personal opinion: This feels kind of "unnecessay", because the Wolfman-class contains
         *    the implementation of the Talk method. But I have't found a way around it.
         */
        void IPerson.Talk()
        {
            Console.WriteLine("Wolfman in its humanoid form is saying arrggrrr.");
        }

        public override string Stats() => $"Name: {Name}\n\t • Weight: {Weight} kg; Age: {Age} years; Color: {Color}; Snout Length: {SnoutLength} cm";

    }

}
