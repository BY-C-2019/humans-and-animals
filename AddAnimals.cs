using System;
using System.Collections.Generic;
namespace humans_and_animals
{
    //En egen klass där man kan lägga till fler djur
    class AddAnimals:Animal
    {
        public static void MoreAnimals()
        {
            Program list= new Program();
           
            Elephant myElephant=new Elephant(); 
            myElephant.species = "Elefant";
            myElephant.name = "Jonas";
            myElephant.hungry= 0;
            Program.myZoo.Add(myElephant);

            Coyote myCoyote=new Coyote(); 
            myCoyote.species = "Prärievarg";
            myCoyote.name = "Martin";
            myCoyote.hungry= 0;
            Program.myZoo.Add(myCoyote);

            Seal mySeal=new Seal(); 
            mySeal.species = "Säl";
            mySeal.name = "Malin";
            mySeal.hungry= 0;
            Program.myZoo.Add(mySeal);

            Bear myBear=new Bear(); 
            myBear.species = "Björn";
            myBear.name = "Lucas";
            myBear.hungry= 0;
            Program.myZoo.Add(myBear);

            Giraffe myGiraffe=new Giraffe(); 
            myGiraffe.species = "Giraff";
            myGiraffe.name = "Viktor";
            myGiraffe.hungry= 0;
            Program.myZoo.Add(myGiraffe);
           
        }
    }
}