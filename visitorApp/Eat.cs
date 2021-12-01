using System;
using System.Collections.Generic;
using System.Text;

namespace visitorApp
{
    class Eat : Visitor
    {
        public void visitCat(Cat cat)
        {
            Console.WriteLine("El gato está comiendo");
        }

        public void visitDog(Dog dog)
        {
            Console.WriteLine("El perro está comiendo");
        }
    }
}
