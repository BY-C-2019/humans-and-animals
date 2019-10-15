using System;
using System.Collections.Generic;

namespace humans_and_animals
{
    class Program
    {
        static void Main(string[] args)
        {
            //För att skapa en ny meny
            Menu newMenu = new Menu();
            Food food=new Food();

            //Kod som kom på köpet ;)
            int day = 0;
            
            while (true) 
            {
            newMenu.AnimalsMenu();
            day++;

            Console.WriteLine("Det är dag " + day + ":");
            Console.WriteLine("-------");
            
            // LÄGG TILL DIN NYA KOD HÄR

            Console.WriteLine("In the Sanctuary, we currently have:\n");

                foreach (Animals animal in newMenu.sanctAnimals)
                {
                    // Skriver ut djuren som finns i Sanctuaryn
                    animal.PrintAnimal();
                    food.incrHunger();

                }
               
                
                
            // Wait for the next day
            Console.ReadKey();
            Console.Clear();
                
                
            }
            
        }
       
    }
    
    
    
}
