using System;
using System.Collections.Generic;

namespace humans_and_animals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> zoo = new List<Animal>();

            //Lägger till djur i zoo
            Bear zooBear1 = new Bear("Berit", 0);
            zoo.Add(zooBear1);

            Bear zooBear2 = new Bear("Bert", 0);
            zoo.Add(zooBear2); 

            Coyote zooCoyote1 = new Coyote("Calle", 0);
            zoo.Add(zooCoyote1);

            Coyote zooCoyote2 = new Coyote("Cissi", 0);
            zoo.Add(zooCoyote2);
            
            Elephant zooElephant1 = new Elephant("Erik", 0);
            zoo.Add(zooElephant1);
            
            Elephant zooElephant2 = new Elephant("Evert", 0);
            zoo.Add(zooElephant2);

            Giraffe zooGiraffe1 = new Giraffe("Gillian", 0);
            zoo.Add(zooGiraffe1);

            Giraffe zooGiraffe2 = new Giraffe("Gurly", 0);
            zoo.Add(zooGiraffe2);

            Seal zooSeal1 = new Seal("Sven", 0);
            zoo.Add(zooSeal1);

            Seal zooSeal2 = new Seal("Svea", 0);
            zoo.Add(zooSeal2);

            foreach (Animal animals in zoo)
            {
                animals.ListOfAnimals();
            }
        }
    }
}
