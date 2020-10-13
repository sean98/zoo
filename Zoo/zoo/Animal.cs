using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.zoo
{
    //Maybe it will be better that Animal will be an abstract class?
    //The methods will be implemented with 'name' and 'sound' variable from c'tor.
    //For examle:   class Dog: Animal { public Dog(): Base("Dog", "How") {} }
    interface Animal
    {
        void printName();
        void printSound();
    }
}
