namespace Zoo.animals
{
    //Maybe it will be better that Animal will be an abstract class?
    //The methods will be implemented with 'name' and 'sound' variable from c'tor.
    //For example:   class Dog: Animal { public Dog(): Base("Dog", "How") {} }
    interface Animal
    {
        void printName();
        void printSound();
    }
}
