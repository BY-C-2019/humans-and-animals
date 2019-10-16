using System;

namespace animal
{
    class Animal
    {
        public string name {get; private set;}
        // The name of the animal
        public string animalType {get; protected set;}
        // Type of animal for example "Elefant"
        protected int hungerLevel;
        // A way to track the animals hunger.
        protected int getHungryAt;
        // At which level the animal gets hungry
        public string foodType {get; protected set;}
        // What the animal eats "Blad", "Kött" or "Allt" is set by constructor
        public void IncreaseHungerLevel()                    
        {  
            // Increases the animals hungerLevel
            hungerLevel++;
        }
        public bool isHungry() 
        {            
            return hungerLevel > getHungryAt;
        }  
        public virtual void Eat() {}                   
        // Should be Abstract
        public virtual void PrintEatSummaryToConsole() 
        {
            // Called from herbivores, carnivores ... to have a generic output
            Console.Write("{0} {1} fick äta {2}", animalType, name, foodType.ToLower());
        }
        public Animal(string Name)
        {
            // Base constructor for every animal
            name = Name;
            hungerLevel = 0;
        }
    }
}