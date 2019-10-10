using System;

namespace humans_and_animals
{
    class Elephant : Animal
    {
        public Elephant (string elephantName, int elephantHungerLevel)
        {
            this.name = elephantName;
            this.hungerLevel = elephantHungerLevel;
        }
        public override void ListOfAnimals()
        {
            Console.WriteLine("{0} är en elefant", name);
        }
    }
}