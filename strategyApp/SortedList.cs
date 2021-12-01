using System;
using System.Collections.Generic;
using System.Text;

namespace strategyApp
{
    public class SortedList
    {
        private List<string> list = new List<string>();
        private SortStrategy sortstrategy;
        public void SetSortStrategy(SortStrategy sortstrategy)
        {
            this.sortstrategy = sortstrategy;
        }
        public void Add(string name)
        {
            list.Add(name);
        }
        public void Sort()
        {
            sortstrategy.Sort(list);
            foreach (string name in list)
            {
                Console.WriteLine(" " + name);
            }
            Console.WriteLine();
        }
    }
}

}
