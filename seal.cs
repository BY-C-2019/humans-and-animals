using carnivore;

namespace seal
{
    class Seal : Carnivore
    {
        public Seal(string Name) : base(Name) 
        {
            animalType = "Säl";
            getHungryAt = 13;

        }
    }
}