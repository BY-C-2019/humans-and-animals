using System;

namespace humans_and_animals
{
    class Giraffes : Animals
    {
        public override void ListOfAnimals()
        {
            Console.WriteLine("{0} är en giraff", name);
        }
    }
}