using System;

namespace humans_and_animals
{
    class Seals : Animals
    {
        public override void ListOfAnimals()
        {
            Console.WriteLine("{0} är en säl", name);
        }
    }
}