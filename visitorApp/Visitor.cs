using System;
using System.Collections.Generic;
using System.Text;

namespace visitorApp
{
    interface Visitor
    {
        void visitCat(Cat cat);
        void visitDog(Dog dog);
    }
}
