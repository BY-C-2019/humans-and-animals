using System;

namespace humans_and_animals
{
    class Giraffe : Animal
    {
        public override void ListOfAnimals()
        {
            Console.WriteLine("{0} är en giraff", name);
        }
    }
}