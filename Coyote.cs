using System;

namespace humans_and_animals
{
    class Coyote : Animal
    {
        public override void ListOfAnimals()
        {
            Console.WriteLine("{0} är en prärievarg", name);
        }
        
    }
}