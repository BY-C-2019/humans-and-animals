using System;

namespace humans_and_animals
{
    class Animal
    {
        public string name;
        public int hungerLevel = 0;
        //En metod för att lägga kunna lägga alla djur i samma lista
        public virtual void ListOfAnimals(ref int nrOfVeggiesLeft, ref int nrOfMeatLeft)
        {
            Console.WriteLine("Jag är ett djur");
        }
        // En metod om det inte finns några blad kvar
        public static void NoVeggisLeft(ref string name)
        {
            Console.WriteLine("{0} ville äta men det fanns ingen mat kvar så lille {0} dog.", name);
        }
        // En metod om det inte finns något kött kvar
        public static void NoMeetLeft(ref string name)
        {
            Console.WriteLine("{0} ville äta men det fanns ingen mat kvar så lille {0} dog.", name);
        }
        // En metod för att öka hungern
        public int RaiseHungerLevel(ref int hungerLevel)
        {
            this.hungerLevel = hungerLevel + 1;
            return hungerLevel;
        }
        // En metod för att nollställa hungern
        public int Eat(ref int hungerLevel)
        {
            hungerLevel = 0;
            return hungerLevel;
        }
    }
}
