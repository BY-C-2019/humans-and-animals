using System;
using System.Collections.Generic;

namespace humans_and_animals
{
    class Menu
    {
        public static List<Animal> myAnimals = new List<Animal>();

        // shows menu to create any amount of aninals
        public static void CreateAnimals()
        {
            bool createAnimals = true;

            while (createAnimals)
            {
                Console.Clear();
                Console.WriteLine("Vilket slags djur vill du skapa?");
                Console.WriteLine("[E]lefant");
                Console.WriteLine("[G]iraff");
                Console.WriteLine("[P]rärievarg");
                Console.WriteLine("[S]äl");
                Console.WriteLine("[B]jörn");
                Console.WriteLine("[D]et räcker med djur");

                string input = Console.ReadLine().ToUpper();

                switch (input)
                {
                    case "E":
                        Elefant myElefant = new Elefant();
                        myElefant.NameYourAnimal();
                        myAnimals.Add(myElefant);
                        break;

                    case "G":
                        Giraffe myGiraffe = new Giraffe();
                        myGiraffe.NameYourAnimal();
                        myAnimals.Add(myGiraffe);
                        break;

                    case "P":
                        Prariewolf myPrariewolf = new Prariewolf();
                        myPrariewolf.NameYourAnimal();
                        myAnimals.Add(myPrariewolf);
                        break;

                    case "S":
                        Seal mySeal = new Seal();
                        mySeal.NameYourAnimal();
                        myAnimals.Add(mySeal);
                        break;

                    case "B":
                        Bear myBear = new Bear();
                        myBear.NameYourAnimal();
                        myAnimals.Add(myBear);
                        break;

                    case "D":
                        createAnimals = false;
                        break;

                    default:
                        Console.WriteLine("Fel val..");
                        break;
                }
            }
        }
    }
}