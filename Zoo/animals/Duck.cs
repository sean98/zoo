using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Duck : Animal
    {
        public void printName()
        {
            Console.WriteLine("Duck");
        }

        public void printSound()
        {
            Console.WriteLine("Ga ga");
        }
    }
}
