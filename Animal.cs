using System;
using System.Collections.Generic;

namespace humans_and_animals
{
    class Animal
    {
        private string name;
        private bool hunger;
        public bool Hunger { get { return hunger; } set { hunger = value; } }
        public string Name { get { return name; } set { name = value; } }
    }
}
