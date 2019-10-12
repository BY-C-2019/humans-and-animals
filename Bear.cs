using System;
using System.Collections.Generic;

namespace humans_and_animals
{
    class Bear : Animal
    {
        List<Bear> bearList = new List<Bear>();
        int hungryInDays;
        public Bear()
        {

        }
        public Bear(string name, bool hunger, int hungerDays)
        {
            this.Name = name;
            this.Hunger = hunger;
            this.hungryInDays = 3;
        }
        public void AddBears()
        {
            //Creates my bears
            Bear snoopy = new Bear("Snoopy", false, hungryInDays);
            Bear björnsson = new Bear("Björnsson", false, hungryInDays);
            bearList.Add(snoopy);
            bearList.Add(björnsson);
        }
        public void CheckHunger()//Minskar när björnen bör äta med en dag och kollar om han är hungrig.
        {
            int nrOfBearsHungry = 0;
            foreach (Bear bear in bearList)
            {
                bear.hungryInDays--;
                if (bear.Name == "Snoopy" && bear.hungryInDays == 0)
                {
                    nrOfBearsHungry++;
                    bear.Hunger = true;
                    bear.hungryInDays = 3;
                    if (Program.nrOfMeatLeft > 0) //if there are is any meatleft
                    {
                        Eat(bear.Name, Program.meat);
                    }
                    else if (Program.nrOfVeggiesLeft > 0) //if there are any veggiesleft
                    {
                        Eat(bear.Name, Program.veggie);
                    }
                    else
                    {
                        Program.foodLeft = false;
                        System.Console.WriteLine("There is no food left.");
                    }
                }
                else if (bear.Name == "Snoopy")
                {
                    System.Console.WriteLine("The bear " + bear.Name + " is satisfied.");
                }
                if (bear.Name == "Björnsson" && bear.hungryInDays == 0)
                {
                    nrOfBearsHungry++;
                    bear.Hunger = true;
                    bear.hungryInDays = 3;
                    if (Program.nrOfVeggiesLeft > 0) //if there are any veggiesleft
                    {
                        Eat(bear.Name, Program.veggie);
                    }
                    else if (Program.nrOfMeatLeft > 0) //if there are is any meatleft
                    {
                        Eat(bear.Name, Program.meat);
                    }
                    else
                    {
                        Program.foodLeft = false;
                        System.Console.WriteLine("There is no food left.");
                    }
                }
                else if (bear.Name == "Björnsson")
                {
                    System.Console.WriteLine("The bear " + bear.Name + " is satisfied.");
                }
            }
        }
        public void Eat(string bearName, string foodName)
        {
            System.Console.Write("The bear " + bearName + " ate {0} and is now satisified. ", foodName);
            if (foodName == "veggie")
            {
                Program.nrOfVeggiesLeft--;
                System.Console.WriteLine("There are {1} {0}(s) left.", foodName, Program.nrOfVeggiesLeft);
            }
            if (foodName == "meat")
            {
                Program.nrOfMeatLeft--;
                System.Console.WriteLine("There are {1} {0}(s) left.", foodName, Program.nrOfMeatLeft);
            }
        }
    }
}

