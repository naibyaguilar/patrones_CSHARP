using System;
using System.Collections.Generic;
using System.Text;

namespace visitorApp
{
    class Dog : Animal
    {
        public void Accept(Visitor visitor)
        {
            visitor.visitDog(this);
        }
    }
}
