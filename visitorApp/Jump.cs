using System;
using System.Collections.Generic;
using System.Text;

namespace visitorApp
{
    class Jump : Visitor
    {
        public void visitCat(Cat cat)
        {
            Console.WriteLine("El gato salta de felicidad");
        }

        public void visitDog(Dog dog)
        {
            Console.WriteLine("El perro salta de felicidad");
        }
    }
}
