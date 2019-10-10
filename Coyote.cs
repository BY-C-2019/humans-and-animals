using System;

namespace humans_and_animals
{
    class Coyote : Animal
    {
        public Coyote(string coyoteName, int coyoteHungerLevel)
        {
            this.name = coyoteName;
            this.hungerLevel = coyoteHungerLevel;
        }
        public override void ListOfAnimals()
        {
            Console.WriteLine("{0} är en prärievarg", name);
        }
        
    }
}