using System;
using System.Collections.Generic;
using System.Text;

namespace strategyApp
{
    public class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("lista Desordenada ");
        }
    }
}
