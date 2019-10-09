using System;

namespace humans_and_animals
{
    class Seal : Animal
    {
        public override void ListOfAnimals()
        {
            Console.WriteLine("{0} är en säl", name);
        }
    }
}