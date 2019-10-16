using herbivore;



namespace giraf
{
    class Giraf : Herbivore
    {
        public Giraf(string Name) : base(Name) 
        {
            animalType = "Giraff";
            getHungryAt = 7;

        }  
    }
}