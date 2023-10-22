namespace OOPArv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Created one object of each class

            Animal newAnimal = new Animal("Djuret", 3, 0, false, "reptil", "väser");
            Bird jennetBird = new Bird("Jennet", 20, 2, "sjunger", true);
            Cat pepperCat = new Cat("Pepper", 11, 4, "jamar", true);
            Dog lisaDog = new Dog("Lisa", 1, 4, "skäller", "jämthund");
            Bulldog mybulldog = new Bulldog("Hank", 5, 3, "skäller högt", "Brun");
            Chihuahua myChihuahua = new Chihuahua("Tindra", 7, 4, "skäller svagt", 3);

            //Demonstrates that all methodes work as they should

            newAnimal.MakeSound();
            jennetBird.MakeSound();
            pepperCat.MakeSound();
            lisaDog.MakeSound();
            mybulldog.MakeSound();
            myChihuahua.MakeSound();

            Console.WriteLine("\n--------------------------\n");

            newAnimal.Eating();
            newAnimal.Sleeping();
            newAnimal.Moving();

            Console.WriteLine("\n--------------------------\n");

            jennetBird.Flying();

            pepperCat.Climbing();

            lisaDog.ChaseBall();

            mybulldog.Guarding();

            myChihuahua.Shaking();
        }
    }
}