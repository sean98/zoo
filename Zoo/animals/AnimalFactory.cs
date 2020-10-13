using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
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
