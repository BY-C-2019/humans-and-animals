using System;

namespace humans_and_animals
{
    public class Animal
    {
        protected string name;
        protected string species;
        protected int hungerLevel = 0;
        protected int maxHunger;

        // method to name your animal
        public void NameYourAnimal()
        {
            Console.Write("Ange djurets namn: ");
            name = Console.ReadLine();
        }

        // method to output animal species and name
        public void ShowAnimal()
        {
            Console.WriteLine(species + " " + name);
        }

        // method to tell that animal starves
        protected void AnimalStarves()
        {
            Console.WriteLine(species + " " + name + " har inte fått mat idag :´(");
        }

        // method to raise hunger level
        public void RaiseHungerLevel()
        {
            hungerLevel++;
        }

        // method to check food availability and to let animal eat
        public virtual bool Eat()
        {
            if (Program.nrOfMeatLeft > 0)
            {
                Program.nrOfMeatLeft--;
                hungerLevel = 0;
            }
            else if (Program.nrOfVeggiesLeft > 0)
            {
                Program.nrOfVeggiesLeft--;
                hungerLevel = 0;
            }
            else
            {
                hungerLevel = 3;
                return false;
            }

            Console.WriteLine(name + " var hungrig och åt. Det finns "
            + Program.nrOfVeggiesLeft + " blad och "
            + Program.nrOfMeatLeft + " köttbitar kvar.");

            return true;
        }

        // method to check if animal is hungry
        protected virtual bool isHungry(int hungerLevel)
        {
            if (hungerLevel >= maxHunger)
            {
                return true;
            }
            return false;
        }

        // method to feed animal
        public void GiveFood()
        {
            if (isHungry(hungerLevel))
            {
                // if there's no food left
                if (!Eat())
                {
                    AnimalStarves();
                }
            }
            else
            {
                Console.WriteLine(GetName() + " behöver inte äta.");
            }
        }

        // method to get animal name
        public string GetName()
        {
            return name;
        }
    }

    // eats leaves 
    class Elefant : Animal
    {
        // constructor
        public Elefant()
        {
            species = "Elefant";
            maxHunger = 10;
        }

        public override bool Eat()
        {
            if (Program.nrOfVeggiesLeft > 0)
            {
                Program.nrOfVeggiesLeft--;
                hungerLevel = 0;
                Console.WriteLine(name + " var hungrig och åt. Det finns " + Program.nrOfVeggiesLeft + " blad kvar.");
                return true;
            }

            else
            {
                hungerLevel = 10;
                return false;
            }
        }
    }

    // eats leaves (inherits elefant)
    class Giraffe : Elefant
    {
        public Giraffe()
        {
            species = "Giraff";
            maxHunger = 7;
        }

        public override bool Eat()
        {
            if (Program.nrOfVeggiesLeft > 0)
            {
                Program.nrOfVeggiesLeft--;
                hungerLevel = 0;
                Console.WriteLine(name + " var hungrig och åt. Det finns " + Program.nrOfVeggiesLeft + " blad kvar.");
                return true;
            }

            else
            {
                hungerLevel = 7;
                return false;
            }
        }
    }

    // eats meat 
    class Prariewolf : Animal
    {
        public Prariewolf()
        {
            species = "Prärievarg";
            maxHunger = 15;
        }

        public override bool Eat()
        {
            if (Program.nrOfMeatLeft > 0)
            {
                Program.nrOfMeatLeft--;
                hungerLevel = 0;
                Console.WriteLine(name + " var hungrig och åt. Det finns " + Program.nrOfMeatLeft + " köttbitar kvar.");
                return true;
            }

            else
            {
                hungerLevel = 15;
                return false;
            }
        }
    }

    // eats meat (inherits wolf)
    class Seal : Prariewolf
    {
        public Seal()
        {
            species = "Säl";
            maxHunger = 13;
        }

        public override bool Eat()
        {
            if (Program.nrOfMeatLeft > 0)
            {
                Program.nrOfMeatLeft--;
                hungerLevel = 0;
                Console.WriteLine(name + " var hungrig och åt. Det finns " + Program.nrOfMeatLeft + " köttbitar kvar.");
                return true;
            }

            else
            {
                hungerLevel = 13;
                return false;
            }
        }
    }

    // eats both meat and leaves
    class Bear : Animal
    {
        public Bear()
        {
            species = "Björn";
            maxHunger = 3;
        }
    }
}