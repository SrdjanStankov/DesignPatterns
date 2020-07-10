using System;
using System.Collections.Generic;

namespace DesignPatterns.Strategy
{
    public class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list) => Console.WriteLine("MergeSorted list "); //list.MergeSort(); not-implemented
    }
}
