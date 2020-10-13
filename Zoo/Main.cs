using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Program
    {
        public static string[] getAnimalsNamesFromFile(string filePath)
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
                Console.WriteLine("Too many argumnets provided");
            else
            {
                var animalFactory = new AnimalFactory();
                var filePath = args[0];

                getAnimalsNamesFromFile(filePath)
                    .Select(name => animalFactory.generateAnimal(name))
                    .ToList().ForEach(animal => {
                        animal.printName();
                        animal.printSound();
                    });
            }
        }
    }
}
