using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorApp
{
    public interface IAbstractCollection
    {
        Iterator CreateIterator();
    }
}
