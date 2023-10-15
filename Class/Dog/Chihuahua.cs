using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPArv
{
    //Sub-subclass "Chihuahua"
    class Chihuahua : Dog
    {
        //Exclusive property "Size" for class "Chihuahua"
        public int Size { get; set; }

        public Chihuahua(string name, int age, int numberOfLegs, string sound, int size)
            : base(name, age, numberOfLegs, sound, "chihuahua")
        {
            Size = size;
        }

        //Exclusive metod for class "Chihuahua"
        public void Shaking()
        {
            Console.WriteLine($"{Name} skakar");
        }
    }
}
