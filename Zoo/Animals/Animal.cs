using System;

namespace Zoo.Animals
{
    public abstract class Animal
    {
        public string Name { get; set; } 
        public string Sound { get; set; } 
        protected Animal(string name, string sound)
        {
            this.Name = name;
            this.Sound = sound;
        }

        public void PrintName()
        {
            Console.WriteLine(this.Name);
        }

        public void PrintSound()
        {
            Console.WriteLine(this.Sound);
        }
    }
}
