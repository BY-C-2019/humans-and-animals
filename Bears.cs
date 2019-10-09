using System;

namespace humans_and_animals
{
    class Bears : Animals
    {
        public override void ListOfAnimals()
        {
            Console.WriteLine("{0} är en björn", name);
        }
    }
}