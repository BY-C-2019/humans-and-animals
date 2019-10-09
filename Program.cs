using System;
using System.Collections.Generic;

namespace humans_and_animals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animals> zoo = new List<Animals>();
            Bears zooBear1 = new Bears();
            zooBear1.name = "Berit";
            zooBear1.hungerLevel = 0; 
            zoo.Add(zooBear1);

            Bears zooBear2 = new Bears();
            zooBear2.name = "Bert";
            zooBear2.hungerLevel = 0;
            zoo.Add(zooBear2); 

            Coyotes zooCoyote1 = new Coyotes();
            zooCoyote1.name = "Calle";
            zooCoyote1.hungerLevel = 0;
            zoo.Add(zooCoyote1);

            Coyotes zooCoyote2 = new Coyotes();
            zooCoyote2.name = "Cissi";
            zooCoyote2.hungerLevel = 0;
            zoo.Add(zooCoyote2);
            
            Elephants zooElephant1 = new Elephants();
            zooElephant1.name = "Erik";
            zooElephant1.hungerLevel = 0;
            zoo.Add(zooElephant1);
            
            Elephants zooElephant2 = new Elephants();
            zooElephant2.name = "Evert";
            zooElephant2.hungerLevel = 0;
            zoo.Add(zooElephant2);

            Giraffes zooGiraffe1 = new Giraffes();
            zooGiraffe1.name = "Gillian";
            zooGiraffe1.hungerLevel = 0;
            zoo.Add(zooGiraffe1);

            Giraffes zooGiraffe2 = new Giraffes();
            zooGiraffe2.name = "Gurly";
            zooGiraffe2.hungerLevel = 0;
            zoo.Add(zooGiraffe2);

            Seals zooSeal1 = new Seals();
            zooSeal1.name = "Sven";
            zooSeal1.hungerLevel = 0;
            zoo.Add(zooSeal1);

            Seals zooSeal2 = new Seals();
            zooSeal2.name = "Svea";
            zooSeal2.hungerLevel = 0;
            zoo.Add(zooSeal2);

            foreach (Animals animals in zoo)
            {
                animals.ListOfAnimals();
            }
        }
    }
}
