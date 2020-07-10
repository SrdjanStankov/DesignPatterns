using System;
using System.Collections.Generic;

namespace DesignPatterns.Strategy
{
    public class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list) => Console.WriteLine("ShellSorted list "); //list.ShellSort(); not-implemented
    }
}
