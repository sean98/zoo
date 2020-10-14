using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Zoo.Animals;

namespace Zoo.Utils
{
    static class AnimalFactory
    {
        private static readonly IList<Type> Classes = Assembly.GetExecutingAssembly().GetTypes()
            .Where(c => c.IsSubclassOf(typeof(Animal)))
            .Where(c => c.Namespace == "Zoo.Animals")
            .ToList();

        public static Animal GenerateAnimal(string animalName)
        {
            try
            {
                var animal = Classes.First(c => c.Name.ToLower() == animalName.ToLower());
                return Activator.CreateInstance(animal) as Animal;
            }
            catch (InvalidOperationException)
            {
                throw new ArgumentException(
                    $"'{animalName}' is not a supported animal name, currently supported: " +
                    string.Join(", ", Classes.Select(animal => animal.Name)));
            }
        }
    }
}