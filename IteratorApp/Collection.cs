using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorApp
{
    public class Collection : IAbstractCollection
    {
        List<Item> items = new List<Item>();
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }
        public int Count
        {
            get { return items.Count; }
        }
        public Item this[int index]
        {
            get { return items[index]; }
            set { items.Add(value); }
        }
    }

}
