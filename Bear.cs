using System;

namespace humans_and_animals
{
    class Bear : Animal
    {
        public override void ListOfAnimals()
        {
            Console.WriteLine("{0} är en björn", name);
        }
    }
}