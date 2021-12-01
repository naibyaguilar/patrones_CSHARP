using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorApp
{
    public class Item
    {
        string name;
        public Item(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get { return name; }
        }
    }
}
