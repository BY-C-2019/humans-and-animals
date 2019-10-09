using System;

namespace humans_and_animals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Day loop
            int nrOfMeatLeft = 50;
            int nrOfVeggiesLeft = 50;
            int day = 0;


            // create some animals
            AnimalCreator.CreateAnimals();

            while (true)
            {
                day++;
                Console.WriteLine("Det är dag " + day + ":");
                Console.WriteLine("-------");

                // LÄGG TILL DIN NYA KOD HÄR

                Console.WriteLine("Djuren som finns på djurparken idag:");
                Console.WriteLine();

                foreach (Animal animal in AnimalCreator.myAnimals)
                {

                    Console.WriteLine(animal.GetKind() + " " + animal.GetName());
                }

                // Wait for the next day
                Console.ReadKey();
            }
        }
    }
}