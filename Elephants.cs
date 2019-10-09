using System;

namespace humans_and_animals
{
    class Elephants : Animals
    {
        public override void ListOfAnimals()
        {
            Console.WriteLine("{0} är en elefant", name);
        }
    }
}