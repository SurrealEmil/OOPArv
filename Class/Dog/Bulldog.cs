using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPArv
{
    //Sub-subclass "Bulldog"
    class Bulldog : Dog
    {
        //Exclusive property "Color" for class "Bulldog"
        public string Color { get; set; }

        public Bulldog(string name, int age, int numberOfLegs, string sound, string color)
            : base(name, age, numberOfLegs, sound, "bulldog")
        {
            Color = color;
        }

        //Exclusive metod for class "Bulldog"
        public void Guarding()
        {
            Console.WriteLine($"{Name} står vakt");
        }
    }
}
