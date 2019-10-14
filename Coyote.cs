using System;

namespace humans_and_animals
{
    class Coyote : Animal
    {
        public Coyote(string coyoteName, int coyoteHungerLevel)
        {
            this.name = coyoteName;
            this.hungerLevel = coyoteHungerLevel;
        }
        public override void ListOfAnimals(ref int nrOfVeggiesLeft,ref int nrOfMeatLeft)
        {
            RaiseHungerLevel(ref hungerLevel);
            if (hungerLevel == 15)
            {
                if (nrOfMeatLeft == 0)
                {
                    NoMeetLeft(ref name);
                    return;
                }
                nrOfMeatLeft--;
                Console.WriteLine("Prärievargen {0} behövde äta och åt en köttbit", name);
                Eat(ref hungerLevel);
                
            }
            else
            {
            Console.WriteLine("Prärievargen {0} är är mätt och glad idag", name);
            }
        }
        
    }
}