using System;
using System.Collections.Generic;
using animal;
using giraf;
using elefant;
using coyote;
using seal;
using bear;

namespace humansAndAnimals
{
    public class Program
    {
        public static int nrOfMeatLeft = 50;
        public static int nrOfVeggiesLeft = 50;
        static void Main(string[] args)
        {
            List<Animal> animalList = new List<Animal>();

/* ----------------------------- Create Animals ----------------------------- */
            Animal myGiraf = new Giraf("G");
            Animal myElefant = new Elefant("E");
            Animal myCoyote = new Coyote("C");
            Animal mySeal = new Seal("S");
            Animal myBear = new Bear("B");

/* ------------------------- Add animals to the list ------------------------ */
            animalList.Add(myGiraf);
            animalList.Add(myElefant);
            animalList.Add(myCoyote);
            animalList.Add(mySeal);
            animalList.Add(myBear);

/* -------------------------------- Day loop -------------------------------- */
            int day = 0;
            while (true)
            {
                day++;
                Console.WriteLine("Det är dag " + day + ":");
                Console.WriteLine("-------");

                for (int i = 0; i < animalList.Count; i++)   
                {   // Loop through the animalList 

                    Animal animal = animalList[i];
                    // Set animal variable for easier understanding

                    animal.IncreaseHungerLevel();                    

                    if (animal.isHungry()) // Check if animal is hungry
                    {
                        animal.Eat(); 
                        // If hungry then eat
                        animal.PrintEatSummaryToConsole(); 
                        // Print an summary on what the animal ate
                    }
                    else
                    {
                        Console.WriteLine("{0} {1} behövde inte äta", animal.animalType, animal.name);
                        // If the animal isnt hungry
                    }
                }
                Console.WriteLine();
                // Wait for the next day
                Console.ReadKey();
            }
        }
    }
}
