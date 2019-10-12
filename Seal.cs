using System;
using System.Collections.Generic;

namespace humans_and_animals
{
    class Seal : Animal
    {
        List<Seal> sealList = new List<Seal>();
        int hungryInDays;
        public Seal()
        {

        }
        public Seal(string name, bool hunger, int hungerDays)
        {
            this.Name = name;
            this.Hunger = hunger;
            this.hungryInDays = 13;
        }
        public void AddSeal()
        {
            //Creates my bears
            var dewgong = new Seal("Dewgong", false, hungryInDays);
            var seel = new Seal("Seel", false, hungryInDays);
            sealList.Add(dewgong);
            sealList.Add(seel);
        }
        public void CheckHunger()//Minskar när björnen bör äta med en dag och kollar om han är hungrig.
        {
            int nrOfBearsHungry = 0;
            foreach (Seal animal in sealList)
            {
                animal.hungryInDays--;
                if (animal.Name == "Dewgong" && animal.hungryInDays == 0)
                {
                    nrOfBearsHungry++;
                    animal.Hunger = true;
                    animal.hungryInDays = 13;
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
                else if (animal.Name == "Dewgong")
                {
                    System.Console.WriteLine("The seal " + animal.Name+ " is satisfied.");
                }
                if (animal.Name == "Seel" && animal.hungryInDays == 0)
                {
                    nrOfBearsHungry++;
                    animal.Hunger = true;
                    animal.hungryInDays = 13;
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
                else if (animal.Name == "Seel")
                {
                    System.Console.WriteLine("The seal " + animal.Name+ " is satisfied.");
                }
            }
        }
        public void Eat(string animal)
        {
            Program.nrOfMeatLeft--;
            System.Console.WriteLine("The seal " + animal + " ate a veggie and is now satisified. There are {0} meat(s) left.", Program.nrOfMeatLeft);
        }
    }
}

