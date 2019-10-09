using System;

namespace humans_and_animals
{
    class Coyotes : Animals
    {
        public override void ListOfAnimals()
        {
            Console.WriteLine("{0} är en prärievarg", name);
        }
        
    }
}