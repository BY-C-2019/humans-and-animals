using herbivore;

namespace elefant
{
    class Elefant : Herbivore
    {
        public Elefant(string Name) : base(Name) 
        {
            animalType = "Elefant";
            getHungryAt = 10;
        }
    }
}