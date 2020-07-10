using System;
using System.Collections.Generic;

namespace DesignPatterns.Strategy
{
    public class SortedList
    {
        private List<string> list = new List<string>();
        private SortStrategy? sortStrategy;

        public void SetSortStrategy(SortStrategy sortstrategy) => this.sortStrategy = sortstrategy;

        public void Add(string name) => list.Add(name);

        public void Sort()
        {
            if (sortStrategy is null)
            {
                Console.WriteLine($"Sort strategy not set!");
                return;
            }

            sortStrategy.Sort(list);

            foreach (var name in list)
            {
                Console.WriteLine(" " + name);
            }
            Console.WriteLine();
        }
    }
}
