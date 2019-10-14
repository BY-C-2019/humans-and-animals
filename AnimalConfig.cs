using System;
using System.Collections.Generic;
namespace humans_and_animals
{
    class Animal
    {   
        //Deklarerade variabler som kan användas i alla klasser.
        public string name;
        public string species;
        public int hungry;
        public virtual void printAnimal()
        {
            Console.WriteLine();
        }
        public virtual void Eat()
        {
            Console.WriteLine();
        }
        //Metod som ökar hungern på alla djuren för varje dag som går
        public void IncreaseHunger()
        {
            hungry++;
        }
    }
    //En subklass till klassen animal
    //En egen subklass till varje djur
    class Bear : Animal
    { 
        //Metod som sparar djurart och namn
        public override void printAnimal()
        {
            Console.WriteLine("Djurart:"+species+"\nNamn:"+name+"\nFöda: Kött & blad\n");
        }
        public override void Eat()
        {  //En if-sats som gör att björnen äter när den är hungrig.
          //Den äter maten det finns mest av kvar
            if(hungry==3 && Program.nrOfMeatLeft>=Program.nrOfVeggiesLeft){
                Console.WriteLine(name+" blev hungrig och åt mat.");
                hungry=0;
                Program.nrOfMeatLeft--;
            } else if(hungry==3 && Program.nrOfMeatLeft<=Program.nrOfVeggiesLeft){
                Console.WriteLine(name+" blev hungrig och åt mat.");
                hungry=0;
                Program.nrOfVeggiesLeft--;
            }
        }
    }
    class Elephant : Animal
    {
        public override void printAnimal()
        {
            Console.WriteLine("Djurart:"+species+"\nNamn:"+name+"\nFöda:Blad\n");
        }
        public override void Eat()
        {
            if(hungry==10 && Program.nrOfVeggiesLeft>=1){
                Console.WriteLine(name+" blev hungrig och åt mat.");
                hungry=0;
                Program.nrOfVeggiesLeft=Program.nrOfVeggiesLeft-1;
            }
        }
    }
    class Coyote : Animal
    {
        public override void printAnimal()
        {
            Console.WriteLine("Djurart:"+species+"\nNamn:"+name+"\nFöda:Kött\n");
        }
        public override void Eat()
        {
            if(hungry==15){
                Console.WriteLine(name+" blev hungrig och åt mat.");
                hungry=0;
                Program.nrOfMeatLeft=Program.nrOfMeatLeft-1;
            }
        }
    }
    class Seal : Animal
    {
        public override void printAnimal()
        {
            Console.WriteLine("Djurart:"+species+"\nNamn:"+name+"\nFöda:Kött\n");
        }
        public override void Eat()
        {
            if(hungry==13){
                Console.WriteLine(name+" blev hungrig och åt mat.");
                hungry=0;
                Program.nrOfMeatLeft=Program.nrOfMeatLeft-1;
            }
        }
    }
    class Giraffe : Animal
    {
        public override void printAnimal()
        {
            Console.WriteLine("Djurart:"+species+"\nNamn:"+name+"\nFöda:Blad\n");
        }
        public override void Eat()
        {
            if(hungry==7){
                Console.WriteLine(name+" blev hungrig och åt mat.");
                hungry=0;
                Program.nrOfVeggiesLeft=Program.nrOfVeggiesLeft-1;
            }
        }
    }
}