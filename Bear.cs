using System;

namespace humans_and_animals
{
    class Bear : Animal
    {
        public Bear(string bearName, int bearHungerLevel)
        {
            this.name = bearName;
            this.hungerLevel = bearHungerLevel;
        }
        public override void ListOfAnimals(ref int nrOfVeggiesLeft,ref int nrOfMeatLeft)
        {
            
            RaiseHungerLevel(ref hungerLevel);
            if (hungerLevel == 3)
            {
                if (nrOfMeatLeft >= nrOfVeggiesLeft)
                {
                    if (nrOfMeatLeft == 0)
                    {
                        NoMeetLeft(ref name);
                        return;
                    }
                    nrOfMeatLeft--;
                    Console.WriteLine("Björnen {0} behövde äta och åt en köttbit", name);
                    Eat(ref hungerLevel);
                }
                else
                {
                    if (nrOfVeggiesLeft == 0)
                    {
                        NoVeggisLeft(ref name);
                        return;
                    }
                    nrOfVeggiesLeft--;
                    Console.WriteLine("Björnen {0} behövde äta och åt ett blad",name);
                    Eat(ref hungerLevel);
                }  
            }
            else
            {
            Console.WriteLine("Björnen {0} är mätt och glad idag", name);
            }
        }
    }
}