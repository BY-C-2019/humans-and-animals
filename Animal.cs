using System;

namespace humans_and_animals
{
    public class Animal
    {
        string name;
        protected string kind;

        // method to name your animal
        public void NameYourAnimal()
        {
            Console.Write("Ange djurets namn: ");
            name = Console.ReadLine();
        }

        // gets name
        public string GetName()
        {
            return name;
        }

        // gets kind
        public string GetKind()
        {
            return kind;
        }
    }

    class Elefant : Animal
    {
        public Elefant()
        {
            kind = "Elefant";
        }

    }

    // eats leaves (like elefant)
    class Giraffe : Elefant
    {
        public Giraffe()
        {
            kind = "Giraff";
        }
    }

    // eats meat 
    class Prariewolf : Animal
    {
        public Prariewolf()
        {
            kind = "Prärievarg";
        }
    }

    // eats meat (like wolf)
    class Seal : Prariewolf
    {
        public Seal()
        {
            kind = "Säl";
        }
    }

    // eats both meat and leaves
    class Bear : Animal
    {
        public Bear()
        {
            kind = "Björn";
        }
    }

}