using System;
using System.Collections.Generic;

namespace humans_and_animals
{
    class Giraffe : Animal
    {
        List<Giraffe> giraffeList = new List<Giraffe>();
        int hungryInDays;
        public Giraffe()
        {

        }
        public Giraffe(string name, bool hunger, int hungerDays)
        {
            this.Name = name;
            this.Hunger = hunger;
            this.hungryInDays = 7;
        }
        public void AddGiraffe()
        {
            //Creates my bears
            var långben = new Giraffe("Långben", false, hungryInDays);
            var kalle = new Giraffe("Kalle", false, hungryInDays);
            giraffeList.Add(långben);
            giraffeList.Add(kalle);
        }
        public void CheckHunger()//Minskar när björnen bör äta med en dag och kollar om han är hungrig.
        {
            int nrOfBearsHungry = 0;
            foreach (Giraffe animal in giraffeList)
            {
                animal.hungryInDays--;
                if (animal.Name == "Långben" && animal.hungryInDays == 0)
                {
                    nrOfBearsHungry++;
                    animal.Hunger = true;
                    animal.hungryInDays = 7;
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
                else if (animal.Name == "Långben")
                {
                    System.Console.WriteLine("The giraffe " + animal.Name+ " is satisfied.");
                }
                if (animal.Name == "Kalle" && animal.hungryInDays == 0)
                {
                    nrOfBearsHungry++;
                    animal.Hunger = true;
                    animal.hungryInDays = 7;
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
                else if (animal.Name == "Kalle")
                {
                    System.Console.WriteLine("The giraffe " + animal.Name+ " is satisfied.");
                }
            }
        }
        public void Eat(string animal)
        {
            Program.nrOfVeggiesLeft--;
            System.Console.WriteLine("The giraffe " + animal + " ate a veggie and is now satisified. There are {0} veggie(s) left.", Program.nrOfVeggiesLeft);
        }
    }
}

