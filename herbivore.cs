using System;
using humansAndAnimals;
using animal;

namespace herbivore 
{
    class Herbivore : Animal
    {
        public override void Eat() 
        {
            // Eats if there are any vegtables left and resets the hungerLevel to 0
            if (Program.nrOfVeggiesLeft > 0){
                Program.nrOfVeggiesLeft--;
                hungerLevel = 0;
            }            
        }
        public override void PrintEatSummaryToConsole()
        {
            // Prints what the animal ate and how much food is left
            base.PrintEatSummaryToConsole();
            Console.Write(", det finns {0} kvar", Program.nrOfVeggiesLeft);
            Console.WriteLine();
        }
        public Herbivore(string Name) : base(Name) 
        {
            // Sets the foodType for every Herbivore to "Blad"
            foodType = "Blad";
        }
    }
}