using System;

namespace humans_and_animals
{
    class Program
    {
        public static int nrOfMeatLeft = 1;
        public static int nrOfVeggiesLeft = 1;

        static void Main(string[] args)
        {
            // Day loop
            int day = 0;

            // create some animals
            Menu.CreateAnimals();

            while (true)
            {
                Console.Clear();
                
                day++;
                Console.WriteLine("Det är dag " + day + ":");
                Console.WriteLine("-------");

                // LÄGG TILL DIN NYA KOD HÄR
                Console.WriteLine("Djuren som finns på djurparken idag:");
                Console.WriteLine();

                foreach (Animal animal in Menu.myAnimals)
                {
                    // print which animals are present
                    Console.WriteLine(animal.GetSpecies() + " " + animal.GetName());

                    // check if animal needs to eat
                    animal.CheckHungerLevel();

                    // raise hungerlevel with 1
                    animal.hungerLevel++;
                }

                // Wait for the next day
                Console.ReadKey();
            }
        }
    }
}