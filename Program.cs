using System;
using System.Collections.Generic;

namespace humans_and_animals
{
    class Program
    {
        public int nrOfMeatLeft = 50;
        public int nrOfVeggiesLeft = 50;
        public static void Main(string[] args)
        {
            //just so I can access my non static methods from static method.
            Bear bear = new Bear();
            //lägger till björnarna
            bear.AddBears();
            int day = 0;
            while (true)
            {
                Console.Clear();
                day++;
                Console.WriteLine("Det är dag " + day + ":");
                Console.WriteLine("-------");

                // LÄGG TILL DIN NYA KOD HÄR
                int manyBearHungry = bear.ToEat();
                

                // Wait for the next day
                Console.ReadKey();
            }
        }
    }
}
