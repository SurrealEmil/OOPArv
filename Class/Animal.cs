using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPArv
{
    //Parent class "Animal" with six propreties
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfLegs { get; set; }
        public bool IsMammal { get; set; }
        public string Species { get; set; }
        public string Sound { get; set; }

        //Constructor
        public Animal(string name, int age, int numberOfLegs, bool isMammal, string species, string sound)
        {
            Name = name;
            Age = age;
            NumberOfLegs = numberOfLegs;
            IsMammal = isMammal;
            Species = species;
            Sound = sound;
        }

        //Four metods shared among all classes
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

        public void MakeSound()
        {
            Console.WriteLine($"{Name}, {Sound}!");
        }
    }
}
