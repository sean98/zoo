using System;
using System.Linq;
using System.Reflection;
using Zoo.Animals;
using Zoo.Utils;

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
                var filePath = args[0];

                GetAnimalsNamesFromFile(filePath)
                    .Select(AnimalFactory.GenerateAnimal)
                    .ToList().ForEach(animal => {
                        animal.PrintName();
                        animal.PrintSound();
                    });
            }
        }
    }
}
