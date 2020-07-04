using System;
using System.Collections;

namespace DesignPatterns.Iterator
{
    public class ItemEnum : IEnumerator
    {
        private int position = -1;
        public Item[] items;

        public ItemEnum(Item[] items)
        {
            this.items = items;
        }

        object? IEnumerator.Current { get; }

        public Item Current
        {
            get
            {
                try
                {
                    return items[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public bool MoveNext() => ++position < items.Length;

        public void Reset() => position = -1;
    }
}
