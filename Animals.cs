using System;
using System.Collections.Generic;

namespace humans_and_animals
{

class Animals
{    
  
private string name;
public string Name
{
    get { return name; }
    set { name = value; }
}
private string species;
public string Species
{
    get { return species; }
    set { species = value; }
}
private int hungerlevel=0;
public int HungerLevel
{
    get { return hungerlevel; }
    set { hungerlevel = value; }
}


public void PrintAnimal()
        {
            System.Console.WriteLine($"The {species} named {name}. Their hungerlvl: {HungerLevel}");
        }

public void AnimalName()
        {
            System.Console.Write("What is the name of the animal? : ");
            name = Console.ReadLine();
        }
public void CheckHunger()
        {
        System.Console.Write($"What is {name}'s hungerlevel? : ");
        HungerLevel = Convert.ToInt32( Console.ReadLine() );
        }

}

class Elephants : Animals
{
   public Elephants()
   {
       Species= "Elephant";
       Food food=new Food();
        food.incrHunger();
        food.isHungry(HungerLevel);
       
   } 
}

class Bears : Animals
{
    public Bears()
   {
       Species= "Bear";
       //HungerCheck=1;
       //Food food=new Food();
       
       //food.EatVeggies();
       //food.EatMeat();
   }   
}


class Seals : Animals
{
  public Seals()
   {
       Species= "Seal";
       //HungerCheck=1;
       //Food food=new Food();
       //food.EatMeat();
   } 
}

class Wolves : Animals
{
     public Wolves()
   {
       Species= "Wolf";
       //HungerCheck=1;
       //Food food=new Food();
       //food.EatMeat();
   }      
}
class Giraffes : Animals
{
    public Giraffes()
   {
       Species= "Giraffe";
       //HungerCheck=1;
       //Food food=new Food();
       //food.EatVeggies();
   } 

}
}
