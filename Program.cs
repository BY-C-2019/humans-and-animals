using System;
using System.Collections.Generic;

namespace humans_and_animals
{
    class Program
    {
        public static string veggie = "veggie";
        public static string meat = "meat";
        public static int nrOfMeatLeft = 50;
        public static int nrOfVeggiesLeft = 50;
        public static bool foodLeft = true;
        public static void Main(string[] args)
        {
            //just so I can access my non static methods from static method.
            Bear bear = new Bear();
            Elephant elephant = new Elephant();
            var giraffe = new Giraffe();
            var seal = new Seal();
            var wolf = new Wolf();

            //lägger till björnarna
            bear.AddBears();
            elephant.AddElephant();
            giraffe.AddGiraffe();
            seal.AddSeal();
            wolf.AddWolf();

            int day = 0;
            while (foodLeft == true)
            {
                Console.Clear();
                day++;
                Console.WriteLine("Det är dag " + day + ":");
                Console.WriteLine("-------");

                // LÄGG TILL DIN NYA KOD HÄR
                if (foodLeft == true)
                {
                    bear.CheckHunger();
                }
                if (foodLeft == true)
                {
                    elephant.CheckHunger();
                }
                if (foodLeft == true)
                {
                    giraffe.CheckHunger();
                }
                if (foodLeft == true)
                {
                    seal.CheckHunger();
                }
                if (foodLeft == true)
                {
                    wolf.CheckHunger();
                }
                // Wait for the next day
                Console.ReadKey();
            }
            System.Console.WriteLine("Our animals can't eat we have to shut down the park...");
        }
    }
}
