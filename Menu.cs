using System;
using System.Collections.Generic;

namespace humans_and_animals
{
    class Menu
    {
        //The list where all the animals will be stored.
        public List<Animals> sanctAnimals = new List<Animals>();
 

        // Menu for adding animals to the sanctuary.
        public void AnimalsMenu()
        {
            while (true)
            {
                
                System.Console.WriteLine("Choose what kind of species you want to add.");
                System.Console.WriteLine("1. Elephant");
                System.Console.WriteLine("2. Bear");
                System.Console.WriteLine("3. Seal");
                System.Console.WriteLine("4. Wolf");
                System.Console.WriteLine("5. Giraffe");
                System.Console.WriteLine("0. New Day");

                int userInput = Convert.ToInt32(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        Elephants elephant=new Elephants();
                        elephant.AnimalName();
                        elephant.CheckHunger();
                        sanctAnimals.Add(elephant);
                        break;

                    case 2:
                        Bears bear=new Bears();
                        bear.AnimalName();
                        bear.CheckHunger();
                        sanctAnimals.Add(bear);
                        break;

                    case 3:
                        Seals seal=new Seals();
                        seal.AnimalName();
                        seal.CheckHunger();
                        sanctAnimals.Add(seal);
                        break;

                    case 4:
                        Wolves wolf = new Wolves();
                        wolf.AnimalName();
                        wolf.CheckHunger();
                        sanctAnimals.Add(wolf);
                        break;

                    case 5:
                        Giraffes giraffe = new Giraffes();
                        giraffe.AnimalName();
                        giraffe.CheckHunger();
                        sanctAnimals.Add(giraffe);
                        break;

                    case 0:
                    {      
                        return;
                    }

                    default:
                        System.Console.WriteLine("Wrong input, try again.");
                        break;
                }
            }
        }
    }
} 