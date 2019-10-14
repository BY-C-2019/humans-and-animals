using System;

namespace humans_and_animals
{
    class Seal : Animal
    {
        public Seal(string sealName, int sealHungerLevel)
        {
            this.name = sealName;
            this.hungerLevel = sealHungerLevel;
        }
        public override void ListOfAnimals(ref int nrOfVeggiesLeft,ref int nrOfMeatLeft)
        {
           RaiseHungerLevel(ref hungerLevel);
            if (hungerLevel == 13)
            {
                if (nrOfMeatLeft == 0)
                {
                    NoMeetLeft(ref name);
                    return;
                }
                nrOfMeatLeft--;
                Console.WriteLine("Sälen {0} behövde äta och åt en köttbit", name);
                Eat(ref hungerLevel);
                
            }
            else
            {
            Console.WriteLine("Sälen {0} är mätt och glad idag", name);
            }
        }
    }
}