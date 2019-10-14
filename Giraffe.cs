using System;

namespace humans_and_animals
{
    class Giraffe : Animal
    {
        public Giraffe(string giraffeName, int giraffeHungerLevel)
        {
            this.name = giraffeName;
            this.hungerLevel = giraffeHungerLevel;
        }
        public override void ListOfAnimals(ref int nrOfVeggiesLeft,ref int nrOfMeatLeft)
        {
            RaiseHungerLevel(ref hungerLevel);
            if (hungerLevel == 7)
            {
                if (nrOfVeggiesLeft == 0)
                {
                    NoVeggisLeft(ref name);
                }
                else
                {
                    nrOfVeggiesLeft--;
                    Console.WriteLine("Giraffen {0} behövde äta och åt ett blad", name);
                    Eat(ref hungerLevel);
                }
            }  
            else
            {
                Console.WriteLine("Giraffen {0} är mätt och glad idag", name);
            }
        }
    }
}