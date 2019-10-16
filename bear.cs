using omnivore;


namespace bear
{
    class Bear : Omnivore
    {
        public Bear(string Name) : base(Name) 
        {
            animalType = "Björn";
            getHungryAt = 3;

        }
    }
}