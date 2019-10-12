using System;
using System.Collections.Generic;

namespace humans_and_animals
{
    class Bear : Animal
    {
        List<Bear> bearList = new List<Bear>();
        int hungryInDays;
        static bool eatsMeat = true;
        static bool eatsVeg = true;
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
        public int ToEat()//Minskar när björnen bör äta med en dag och kollar om han är hungrig.
        {
            int nrOfBearsHungry = 0;
            foreach (Bear bear in bearList)
            {
                bear.hungryInDays--;
                Console.WriteLine(bear.hungryInDays);
                if (bear.Name == "Snoopy" && bear.hungryInDays == 0)
                {
                    nrOfBearsHungry++;
                    bear.Hunger = true;
                    bear.hungryInDays = 3;
                }
                if (bear.Name == "Björnsson" && bear.hungryInDays == 0)
                {
                    nrOfBearsHungry++;
                    bear.Hunger = true;
                    bear.hungryInDays = 3;
                }
            }
            return nrOfBearsHungry;
        }
    }
}

