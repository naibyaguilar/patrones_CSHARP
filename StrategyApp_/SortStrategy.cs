using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyApp_
{
    public abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }

}
