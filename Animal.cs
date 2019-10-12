using System;
using System.Collections.Generic;

namespace humans_and_animals
{
    class Animal
    {
        private bool eatMeat;
        private bool eatVeg;
        private string name;
        private bool hunger;
        public bool Hunger { get { return hunger; } set { hunger = value; } }
        public bool EatMeat { get { return eatMeat; } set { eatVeg = value; } }
        public bool EatVeg { get { return eatMeat; } set { eatVeg = value; } }
        public string Name { get { return name; } set { name = value; } }
    }
}
