using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPArv
{
    //Subclass "Bird"
    class Bird : Animal
    {
        //Exclusive property "CanFly" for class "Bird"
        public bool CanFly { get; set; }

        public Bird(string name, int age, int numberOfLegs, string sound, bool canFly)
            : base(name, age, numberOfLegs, false, "Fågel", sound)
        {
            CanFly = canFly;
        }

        //Exclusive metod for class "Bird"
        public void Flying()
        {
            Console.WriteLine($"{Name} flyger");
        }
    }
}
