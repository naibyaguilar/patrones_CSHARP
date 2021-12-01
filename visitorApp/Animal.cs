using System;
using System.Collections.Generic;
using System.Text;

namespace visitorApp
{
    interface Animal
    {
        void Accept(Visitor visitor);

    }
}
