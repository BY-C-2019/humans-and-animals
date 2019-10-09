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
            while (true)
            {
                day++;
                Console.WriteLine("Det är dag " + day + ":");
                Console.WriteLine("-------");

                // LÄGG TILL DIN NYA KOD HÄR

                // Wait for the next day
                Console.ReadKey();
            }
        }
    }
}
