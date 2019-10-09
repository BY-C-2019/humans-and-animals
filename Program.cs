using System;
using System.Collections.Generic;

namespace humans_and_animals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> zoo = new List<Animal>();

            Bear zooBear1 = new Bear();
            zooBear1.name = "Berit";
            zooBear1.hungerLevel = 0; 
            zoo.Add(zooBear1);

            Bear zooBear2 = new Bear();
            zooBear2.name = "Bert";
            zooBear2.hungerLevel = 0;
            zoo.Add(zooBear2); 

            Coyote zooCoyote1 = new Coyote();
            zooCoyote1.name = "Calle";
            zooCoyote1.hungerLevel = 0;
            zoo.Add(zooCoyote1);

            Coyote zooCoyote2 = new Coyote();
            zooCoyote2.name = "Cissi";
            zooCoyote2.hungerLevel = 0;
            zoo.Add(zooCoyote2);
            
            Elephant zooElephant1 = new Elephant();
            zooElephant1.name = "Erik";
            zooElephant1.hungerLevel = 0;
            zoo.Add(zooElephant1);
            
            Elephant zooElephant2 = new Elephant();
            zooElephant2.name = "Evert";
            zooElephant2.hungerLevel = 0;
            zoo.Add(zooElephant2);

            Giraffe zooGiraffe1 = new Giraffe();
            zooGiraffe1.name = "Gillian";
            zooGiraffe1.hungerLevel = 0;
            zoo.Add(zooGiraffe1);

            Giraffe zooGiraffe2 = new Giraffe();
            zooGiraffe2.name = "Gurly";
            zooGiraffe2.hungerLevel = 0;
            zoo.Add(zooGiraffe2);

            Seal zooSeal1 = new Seal();
            zooSeal1.name = "Sven";
            zooSeal1.hungerLevel = 0;
            zoo.Add(zooSeal1);

            Seal zooSeal2 = new Seal();
            zooSeal2.name = "Svea";
            zooSeal2.hungerLevel = 0;
            zoo.Add(zooSeal2);

            foreach (Animal animals in zoo)
            {
                animals.ListOfAnimals();
            }
        }
    }
}
