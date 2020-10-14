using System;

namespace Zoo.animals
{
    class AnimalFactory
    {
        public Animal generateAnimal(string animalName)
        {
            switch (animalName.ToLower())
            {
                case "dog": return new Dog();
                case "cat": return new Cat();
                case "duck": return new Duck();
                default: throw new ArgumentException($"'{animalName}' is not a supported animal name");
            }
        }
    }
}
