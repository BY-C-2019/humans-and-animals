using System;

namespace humans_and_animals
{
    class Program
    {
        public static int nrOfMeatLeft = 50;
        public static int nrOfVeggiesLeft = 50;

        static void Main(string[] args)
        {
            // Day loop
            int day = 0;

            // create some animals
            Menu.CreateAnimals();

            while (true)
            {
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

                    // raise hungerlevel with 1
                    animal.hungerLevel++;

                    // switch to check individual hunger levels
                    switch (animal.GetSpecies())
                    {
                        case "Elefant":
                            if (animal.isHungry(animal.hungerLevel))
                            {
                                // if there's no food left
                                if (!animal.Eat())
                                {
                                    animal.AnimalStarves();
                                }
                            }
                            else
                            {
                                Console.WriteLine(animal.GetName() + " behöver inte äta.");
                            }
                            break;
                    }
                }

                // Wait for the next day
                Console.ReadKey();
            }
        }
    }
}