using System;

namespace humans_and_animals
{
    public class Animal
    {
        protected string name;
        protected string species;
        public int hungerLevel = 0;
        protected int maxHunger;

        // method to name your animal
        public void NameYourAnimal()
        {
            Console.Write("Ange djurets namn: ");
            name = Console.ReadLine();
        }

        // method to tell that animal starves
        public void AnimalStarves()
        {
            Console.WriteLine(species + " " + name + " har inte fått mat idag :´(");
        }

        // method that checks food availability and lets animal eat
        public virtual bool Eat()
        {
            if (Program.nrOfMeatLeft > 0 && Program.nrOfVeggiesLeft > 0)
            {
                Program.nrOfMeatLeft--;
                Program.nrOfVeggiesLeft--;
                hungerLevel = 0;
                return true;
            }

            else
            {
                return false;
            }
        }

        // method to check if animal is hungry 
        public virtual bool isHungry(int hungerLevel)
        {
            if (hungerLevel >= maxHunger)
            {
                return true;
            }
            return false;
        }

        public void CheckHungerLevel()
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
                Console.WriteLine(GetSpecies() + " " + GetName() + " behöver inte äta.");
            }
        }
        // gets animal name
        public string GetName()
        {
            return name;
        }

        // gets animal species
        public string GetSpecies()
        {
            return species;
        }

    }

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
                return false;
            }
        }
    }

    // eats leaves (like elefant)
    class Giraffe : Elefant
    {
        public Giraffe()
        {
            species = "Giraff";
            maxHunger = 7;
        }

           // method that checks food availability and lets animal eat
        public override bool Eat()
        {
            if (Program.nrOfVeggiesLeft > 0)
            {
                Program.nrOfVeggiesLeft--;
                hungerLevel = 0;
                return true;
            }

            else
            {
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
    }

    // eats meat (like wolf)
    class Seal : Prariewolf
    {
        public Seal()
        {
            species = "Säl";
            maxHunger = 13;
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