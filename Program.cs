namespace OOPArv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bulldog mybulldog = new Bulldog("Hank", 5, 3, "Brun");

            mybulldog.Eating();
        }
    }

    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfLegs { get; set; }
        public bool IsMammal { get; set; }
        public string Species { get; set; }

        public Animal(string name, int age, int numberOfLegs, bool isMammal, string species)
        {
            Name = name;
            Age = age;
            NumberOfLegs = numberOfLegs;
            IsMammal = isMammal;
            Species = species;
        }

        public void Eating()
        {
            Console.WriteLine($"{Name} äter");
        }

        public void Sleeping()
        {
            Console.WriteLine($"{Name} sover");
        }

        public void Moving()
        {
            Console.WriteLine($"{Name} rör på sig");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} gör ett ljud");
        }
    }
    class Bird : Animal
    {
        public bool CanFly { get; set; }

        public Bird(string name, int age, int numberOfLegs, bool canFly)
            : base(name, age, numberOfLegs, false, "Fågel")
        {
            CanFly = canFly;
        }

        public void Flying()
        {
            Console.WriteLine($"{Name} flyger");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} Sjunger: Pip! Pip!");
        }
    }

    class Cat : Animal
    {
        public bool IsLasy { get; set; }

        public Cat(string name, int age, int numberOfLegs, bool isLasy)
            : base(name, age, numberOfLegs, true, "Katt")
        {
            IsLasy = isLasy;
        }

        public void Climbing()
        {
            Console.WriteLine($"{Name} klättrar");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} jamar: Meow! Meow!");
        }
    }

    class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string name, int age, int numberOfLegs, string breed)
            : base(name, age, numberOfLegs, true, "Hund")
        {
            Breed = breed;
        }

        public void ChaseBall()
        {
            Console.WriteLine($"{Name} jagar bollen!");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} skäller: Voff! voff!");
        }
    }

    class Bulldog : Dog
    {
        public string Color { get; set; }

        public Bulldog(string name, int age, int numberOfLegs, string color)
            : base(name, age, numberOfLegs, "bulldog")
        {
            Color = color;
        }

        public void Guarding()
        {
            Console.WriteLine($"{Name} står vakt");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} skäller grovt: Voff! voff!");
        }
    }

    class Chihuahua : Dog
    {
        public int Size { get; set; }

        public Chihuahua(string name, int age, int numberOfLegs, int size)
            : base(name, age, numberOfLegs, "chihuahua")
        {
            Size = size;
        }

        public void Shaking()
        {
            Console.WriteLine($"{Name} står och skakar");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} skäller svagt: voff! voff!");
        }
    }
}