using carnivore;

namespace coyote
{
    class Coyote : Carnivore
    {
        public Coyote(string Name) : base(Name) 
        {
            animalType = "Prärievarg";
            getHungryAt = 15;

        }
    }
}