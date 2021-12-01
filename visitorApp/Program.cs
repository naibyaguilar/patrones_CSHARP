using System;

namespace visitorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();

            Cat cat = new Cat();

            dog.Accept(new Eat());

            cat.Accept(new Jump());

            Console.ReadKey();
        }
    }
}
