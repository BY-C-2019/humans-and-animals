using System;

namespace humans_and_animals
{
    class Animals
    {
        public string name;
        public int hungerLevel = 0;

        public virtual void ListOfAnimals()
        {
            Console.WriteLine("Jag är ett djur");
        }
    }
}
