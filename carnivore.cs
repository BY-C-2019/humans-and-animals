using System;
using animal;
using humansAndAnimals;

namespace carnivore
{
    class Carnivore : Animal
    {
        public override void Eat() 
        {
            // Eats if there are any meat left,
            // and resets the hungerLevel to 0 if there are any food left
             
            if (Program.nrOfMeatLeft > 0){
                Program.nrOfMeatLeft--;
                hungerLevel = 0;
            }
        }
        public override void PrintEatSummaryToConsole()
        {
            // Prints what the animal ate and how much food is left
            // Is calling to base for generic output
            base.PrintEatSummaryToConsole();
            Console.Write(", det finns {0} kvar", Program.nrOfMeatLeft);
            Console.WriteLine();
        }
        public Carnivore(string Name) : base(Name) 
        {
            // Sets every Carnivore foodType to "Kött"
            foodType = "Kött";
        }
    }
}