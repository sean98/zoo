using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.zoo
{
    class Cat : Animal
    {
        public void printName()
        {
            Console.WriteLine("Cat");
        }

        public void printSound()
        {
            Console.WriteLine("Miao");
        }
    }
}
