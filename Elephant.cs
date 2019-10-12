using System;
using System.Collections.Generic;

namespace humans_and_animals
{
    class Elephant : Animal
    {
        List<Elephant> elephantList = new List<Elephant>();
        int hungryInDays;
        public Elephant()
        {

        }
        public Elephant(string name, bool hunger, int hungerDays)
        {
            this.Name = name;
            this.Hunger = hunger;
            this.hungryInDays = 10;
        }
        public void AddElephant()
        {
            //Creates my bears
            var dumbo = new Elephant("Dumbo", false, hungryInDays);
            var pellefanten = new Elephant("Pellefanten", false, hungryInDays);
            elephantList.Add(dumbo);
            elephantList.Add(pellefanten);
        }
        public void CheckHunger()//Minskar när björnen bör äta med en dag och kollar om han är hungrig.
        {
            int nrOfBearsHungry = 0;
            foreach (Elephant animal in elephantList)
            {
                animal.hungryInDays--;
                if (animal.Name == "Dumbo" && animal.hungryInDays == 0)
                {
                    nrOfBearsHungry++;
                    animal.Hunger = true;
                    animal.hungryInDays = 10;
                    if (Program.nrOfVeggiesLeft > 0) //if there are any veggiesleft
                    {
                        Eat(animal.Name);
                    }
                    else
                    {
                        Program.foodLeft = false;
                        System.Console.WriteLine("There is no food left.");
                    }
                }
                else if (animal.Name == "Dumbo")
                {
                    System.Console.WriteLine("The elephant " + animal.Name+ " is satisfied.");
                }
                if (animal.Name == "Pellefanten" && animal.hungryInDays == 0)
                {
                    nrOfBearsHungry++;
                    animal.Hunger = true;
                    animal.hungryInDays = 10;
                    if (Program.nrOfVeggiesLeft > 0) //if there are any veggiesleft
                    {
                        Eat(animal.Name);
                    }
                    else
                    {
                        Program.foodLeft = false;
                        System.Console.WriteLine("There is no food left.");
                    }
                }
                else if (animal.Name == "Pellefanten")
                {
                    System.Console.WriteLine("The elephant " + animal.Name+ " is satisfied.");
                }
            }
        }
        public void Eat(string animal)
        {
            Program.nrOfVeggiesLeft--;
            System.Console.WriteLine("The elephant " + animal + " ate a veggie and is now satisified. There are {0} veggie(s) left.", Program.nrOfVeggiesLeft);
        }
    }
}

