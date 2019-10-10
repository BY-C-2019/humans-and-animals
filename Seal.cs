using System;

namespace humans_and_animals
{
    class Seal : Animal
    {
        public Seal(string sealName, int sealHungerLevel)
        {
            this.name = sealName;
            this.hungerLevel = sealHungerLevel;
        }
        public override void ListOfAnimals()
        {
            Console.WriteLine("{0} är en säl", name);
        }
    }
}