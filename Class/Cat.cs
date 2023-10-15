using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPArv
{
    //Subclass "Cat"
    class Cat : Animal
    {
        //Exclusive property "IsLasy" for class "Cat"
        public bool IsLasy { get; set; }

        public Cat(string name, int age, int numberOfLegs, string sound, bool isLasy)
            : base(name, age, numberOfLegs, true, "Katt", sound)
        {
            IsLasy = isLasy;
        }

        //Exclusive metod for class "Cat"
        public void Climbing()
        {
            Console.WriteLine($"{Name} klättrar");
        }
    }
}
