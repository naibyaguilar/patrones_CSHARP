﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyApp_
{
    public class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort(); 
            Console.WriteLine("Lista clasificada rápida ");
        }
       
    }
}
