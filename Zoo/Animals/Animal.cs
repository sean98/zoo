using System;

namespace Zoo.Animals
{
    public abstract class Animal
    {
        public string Name { get; } 
        public string Sound { get; } 
        
        protected Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }

        public void PrintName()
        {
            Console.WriteLine(Name);
        }

        public void PrintSound()
        {
            Console.WriteLine(Sound);
        }
    }
}
