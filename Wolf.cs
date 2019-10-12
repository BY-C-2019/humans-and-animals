using System;
using System.Collections.Generic;

namespace humans_and_animals
{
    class Wolf : Animal
    {
        List<Wolf> wolfList = new List<Wolf>();
        int hungryInDays;
        public Wolf()
        {

        }
        public Wolf(string name, bool hunger, int hungerDays)
        {
            this.Name = name;
            this.Hunger = hunger;
            this.hungryInDays = 15;
        }
        public void AddWolf()
        {
            //Creates my bears
            var poochyena  = new Wolf("Poochyena", false, hungryInDays);
            var mightyena = new Wolf("Mightyena", false, hungryInDays);
            wolfList.Add(poochyena);
            wolfList.Add(mightyena);
        }
        public void CheckHunger()//Minskar när björnen bör äta med en dag och kollar om han är hungrig.
        {
            int nrOfBearsHungry = 0;
            foreach (Wolf animal in wolfList)
            {
                animal.hungryInDays--;
                if (animal.Name == "Poochyena" && animal.hungryInDays == 0)
                {
                    nrOfBearsHungry++;
                    animal.Hunger = true;
                    animal.hungryInDays = 15;
                    if (Program.nrOfMeatLeft > 0) //if there are any meatleft
                    {
                        Eat(animal.Name);
                    }
                    else
                    {
                        Program.foodLeft = false;
                        System.Console.WriteLine("There is no food left.");
                    }
                }
                else if (animal.Name == "Poochyena")
                {
                    System.Console.WriteLine("The wolf " + animal.Name+ " is satisfied.");
                }
                if (animal.Name == "Mightyena" && animal.hungryInDays == 0)
                {
                    nrOfBearsHungry++;
                    animal.Hunger = true;
                    animal.hungryInDays = 15;
                    if (Program.nrOfMeatLeft > 0) //if there are any meatleft
                    {
                        Eat(animal.Name);
                    }
                    else
                    {
                        Program.foodLeft = false;
                        System.Console.WriteLine("There is no food left.");
                    }
                }
                else if (animal.Name == "Mightyena")
                {
                    System.Console.WriteLine("The wolf " + animal.Name+ " is satisfied.");
                }
            }
        }
        public void Eat(string animal)
        {
            Program.nrOfMeatLeft--;
            System.Console.WriteLine("The wolf " + animal + " ate a veggie and is now satisified. There are {0} meat(s) left.", Program.nrOfMeatLeft);
        }
    }
}

