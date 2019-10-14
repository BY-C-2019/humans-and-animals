using System;

namespace humans_and_animals
{
    class Elephant : Animal
    {
        public Elephant (string elephantName, int elephantHungerLevel)
        {
            this.name = elephantName;
            this.hungerLevel = elephantHungerLevel;
        }
        public override void ListOfAnimals(ref int nrOfVeggiesLeft,ref int nrOfMeatLeft)
        {
            RaiseHungerLevel(ref hungerLevel);
            if (hungerLevel == 10)
            {
                if (nrOfVeggiesLeft == 0)
                {
                    NoVeggisLeft(ref name);
                    return;
                }
                else
                {
                    nrOfVeggiesLeft--;
                    Console.WriteLine("Elefanten {0} behövde äta och åt ett blad", name);
                    Eat(ref hungerLevel);
                }
            }  
            else
            {
                Console.WriteLine("Elefanten {0} är mätt och glad idag", name);
            }
        }
    }
}