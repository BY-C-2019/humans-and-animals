using System;

namespace humans_and_animals
{
    class Bear : Animal
    {
        public Bear(string bearName, int bearHungerLevel)
        {
            this.name = bearName;
            this.hungerLevel = bearHungerLevel;
        }
        public override void ListOfAnimals()
        {
            Console.WriteLine("{0} är en björn", name);
        }
    }
}