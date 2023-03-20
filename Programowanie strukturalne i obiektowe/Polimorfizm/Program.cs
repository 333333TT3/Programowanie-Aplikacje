using System;

namespace Polimorfizm
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Burek");

            dog.Bark();

            dog.ShowInfo();
        }
    }
}