using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPArv
{
    //Subclass "Dog"
    class Dog : Animal
    {
        //Exclusive property "Breed" for class "Dog"
        public string Breed { get; set; }

        public Dog(string name, int age, int numberOfLegs, string sound, string breed)
            : base(name, age, numberOfLegs, true, "Hund", sound)
        {
            Breed = breed;
        }

        //Exclusive metod for class "Dog"
        public void ChaseBall()
        {
            Console.WriteLine($"{Name} jagar bollen!");
        }
    }
}
