using System;
using System.Collections.Generic;
namespace humans_and_animals
{
    class Program
    {
        //Deklarerae variabler som kan användas i flera klasser
        public static int nrOfMeatLeft = 50;
        public static int nrOfVeggiesLeft = 50;
        public static bool menyRun=true;
        //Lista med alla djuren
        static public List<Animal> myZoo=new List<Animal>();
        static void Main(string[] args)
        {
            //Lägger till djuren som är skrivna i klassen AddAnimals.
            AddAnimals.MoreAnimals();
            //Skriver ut djuren som finns i parken
            Console.WriteLine("Djur som finns i parken:");
            foreach (Animal animal in myZoo)
            {
                animal.printAnimal();
            }
            Console.ReadKey();
            
            
            int day = 0;
            while (menyRun) {
            Console.Clear();
            day++;
            Console.WriteLine("Det är dag " + day + ":");
            //Skirver ut hur många blad och köttbitar som finns kvar
            Console.WriteLine("Blad kvar:"+nrOfVeggiesLeft+"\nKött kvar:"+nrOfMeatLeft);
            Console.WriteLine("-------");
            //Loop för att öka hungern och skriva ut om något djur äter
            foreach (Animal animal in myZoo)
            {
                animal.IncreaseHunger();
                animal.Eat();
            }
            //En ifsats som avslutar programmet om maten är slut
            if(nrOfMeatLeft==0 || nrOfVeggiesLeft==0){
                Console.WriteLine("Maten är slut!");
                menyRun=false;
            }
            // Wait for the next day
            Console.ReadKey();
        
        }
            
        }
    }
}
