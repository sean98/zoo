using System;
using System.Linq;
using Zoo.Animals;

namespace Zoo
{
    static class Program
    {
        private static string[] GetAnimalsNamesFromFile(string filePath)
        {
            return System.IO.File
                .ReadAllText(filePath)
                .Trim().Split(' ');
        }
        static void Main(string[] args)
        {
            if (args.Length < 1)
                Console.WriteLine("file path was not provided");
            else if (args.Length > 1)
                Console.WriteLine("Too many arguments provided");
            else
            {
                var animalFactory = new AnimalFactory();
                var filePath = args[0];

                GetAnimalsNamesFromFile(filePath)
                    .Select(name => animalFactory.generateAnimal(name))
                    .ToList().ForEach(animal => {
                        animal.PrintName();
                        animal.PrintSound();
                    });
            }
        }
    }
}
