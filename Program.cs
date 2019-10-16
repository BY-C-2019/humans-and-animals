using System;
using System.Collections.Generic;

namespace humans_and_animals
{
    class List
    {
        public void ShowAnimalList()
        {
            
        
        
            List<string> listOfAnimals = new List<string>();

            listOfAnimals.Add("Elefant");
            listOfAnimals.Add("Giraff");
            listOfAnimals.Add("Prärievarg");
            listOfAnimals.Add("Säl");
            listOfAnimals.Add("Björn");


            System.Console.WriteLine("Djur i djurparken: \n");
            for(int i = 0; i < listOfAnimals.Count; i++)
            {
                Console.Write(listOfAnimals[i] + "\n");

            }

        }
    





        
    }


    class Program 
    {
            
        public static int nrOfMeatLeft = 50;
        public static int nrOfVeggiesLeft = 50;
        
    
        static void Main(string[] args)
        {
            
            
            List myList = new List();
            Elephant myElephant = new Elephant();
            Giraffe myGiraffe = new Giraffe();
            Coyote myCoyote = new Coyote();
            Seals mySeals = new Seals();
            Bear myBear = new Bear();

            myList.ShowAnimalList();
            Console.ReadKey();

            // Day loop
            int day = 0;
            while (true) {
            Console.Clear();
            day++;
            
            Console.WriteLine("Det är dag " + day + ":");
            System.Console.WriteLine("Vegetarisk kost volym: " + nrOfVeggiesLeft + "\nAnimalisk kost volym: " + nrOfMeatLeft);
            Console.WriteLine("-------");
            
            
            // LÄGG TILL DIN NYA KOD HÄR
            
            myBear.BearHunger();

            myElephant.ElephantHunger();
            
            myGiraffe.GiraffeHunger();

            myCoyote.CoyoteHunger();

            mySeals.SealHunger();
            
            if(nrOfMeatLeft == 0 || nrOfVeggiesLeft == 0)
            {
                Console.Clear();
                System.Console.WriteLine("Maten är slut och det måste köpas in mer, ASP!");

                Console.ReadKey();
                break;

            }


            
            Console.ReadKey();
            }
        }
    
    
    
    
    
    
    }
    


}
