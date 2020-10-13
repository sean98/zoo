using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Dog : Animal
    {
        public void printName()
        {
            Console.WriteLine("Dog");
        }

        public void printSound()
        {
            Console.WriteLine("How");
        }
    }
}
