using System;

namespace humans_and_animals
{
    class Giraffe : Animal
    {
        public Giraffe(string giraffeName, int giraffeHungerLevel)
        {
            this.name = giraffeName;
            this.hungerLevel = giraffeHungerLevel;
        }
        public override void ListOfAnimals()
        {
            Console.WriteLine("{0} är en giraff", name);
        }
    }
}