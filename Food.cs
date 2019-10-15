using System;
using System.Collections.Generic;

namespace humans_and_animals
{

    //Everything Foodrelated.
class Food : Animals
{
    int nrOfMeatLeft = 50;
    int nrOfVeggiesLeft=50;
    int HungerTick=0;

public void incrHunger()
{
    System.Console.WriteLine($"{HungerTick}");
    HungerTick++;
}

public bool isHungry(int HungerLevel)
        {
            if (HungerTick >= HungerLevel)
            {
                return true;
            }
            return false;
        }
public void Feed()
        {
            if (isHungry(HungerTick))
            {
                if(Species=="Giraffes"||Species == "Elephant")
                {
                    Herbivore();
                }
                else if(Species=="Seals"||Species =="Wolves")
                {
                    Carnivore();
                }
                else if(Species=="Bears")
                {
                    Omnivore();
                }
                
                // if there's no food left
                else if(!Herbivore() || !Carnivore())
                {
                    Starving();
                }
                
            }
            else
            {
                System.Console.WriteLine($"{Name} the {Species} isn't hungry.");
            }
        }


public void Starving()
        {
            System.Console.WriteLine($"{Name} is starving!! Authorities have been notified...\n");
            System.Console.WriteLine("Due to negligence, your sanctuary has been shut down.");
            System.Console.WriteLine("-- The End --");
            Console.ReadKey();
            return;
        }   
public bool Herbivore()
        {

            if (nrOfVeggiesLeft > 0)
            {
                nrOfVeggiesLeft--;
                HungerTick = 0;
                
            System.Console.WriteLine($"{Name} was hungry, {Name} has been fed.");
            System.Console.WriteLine($"There are {nrOfVeggiesLeft} veggies left. ");
             return true;
            }
            else
            {
                return false;
            }
        }

public bool Carnivore()
        {

            if (nrOfMeatLeft > 0)
            {
                nrOfMeatLeft--;
                HungerTick = 0;
                System.Console.WriteLine($"{Name} was hungry, {Name} has been fed.");
                System.Console.WriteLine($"There are {nrOfMeatLeft} meats left. ");

            return true;
            }
            else
            {
                return false;
            }   
        }
public bool Omnivore()
        {

            if (nrOfMeatLeft > nrOfVeggiesLeft)
            {
                nrOfMeatLeft--;
                HungerTick = 0;
                System.Console.WriteLine($"{Name} was hungry, {Name} has been fed.");
            System.Console.WriteLine($"There are {nrOfMeatLeft} meats left. ");
            }
            if (nrOfVeggiesLeft > nrOfMeatLeft)
            {
                nrOfVeggiesLeft--;
                HungerTick = 0;
                System.Console.WriteLine($"{Name} was hungry, {Name} has been fed.");
                System.Console.WriteLine($"There are {nrOfVeggiesLeft} meats left. ");
                return true;

            }
            else
            {
                return false;
            }
        }

}

}