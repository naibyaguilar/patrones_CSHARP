using System;
using System.Collections.Generic;
using System.Text;

namespace visitorApp
{
    class Cat : Animal
    {
        public void Accept(Visitor visitor)
        {
            visitor.visitCat(this);
        }
    }
}
