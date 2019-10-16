using animal;
using humansAndAnimals;
using System;

namespace omnivore
{
    class Omnivore : Animal
    {
        public override void Eat()
        {
            if (Program.nrOfVeggiesLeft > 0){
                Program.nrOfVeggiesLeft--;
                hungerLevel = 0;
            }
            else if(Program.nrOfMeatLeft > 0)
            {
                Program.nrOfMeatLeft--;
                hungerLevel = 0;
            }
        }
        public override void PrintEatSummaryToConsole()
        {
            base.PrintEatSummaryToConsole();
            Console.Write(", det finns {0} blad kvar och {1} kött kvar", Program.nrOfVeggiesLeft, Program.nrOfMeatLeft);
            Console.WriteLine();
        }
        public Omnivore(string Name) : base(Name) 
        {
            foodType = "Allt";
        }
    }
}