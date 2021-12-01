using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyApp_
{
    public class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("lista Desordenada ");
        }
    }
}
