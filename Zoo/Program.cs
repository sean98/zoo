using System;
using System.IO;
using System.Linq;
using Zoo.Utils;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
                Console.WriteLine("file path was not provided");
            else if (args.Length > 1)
                Console.WriteLine($"Too many arguments provided: expected 1, provided {args.Length}");
            else
            {
                var filePath = args[0];

                try
                {
                    var animals = AnimalUtils.GetAnimalsNamesFromFile(filePath)
                        .Select(AnimalFactory.GenerateAnimal);

                    foreach (var animal in animals)
                    {
                        animal.PrintName();
                        animal.PrintSound();
                    }
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine($"Couldn't find file {filePath}");
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}