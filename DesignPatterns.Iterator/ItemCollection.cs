using System.Collections;

namespace DesignPatterns.Iterator
{
    public class ItemCollection : IEnumerable
    {
        private Item[] items;

        public ItemCollection(Item[] items)
        {
            this.items = new Item[items.Length];
            for (var i = 0; i < items.Length; i++)
            {
                this.items[i] = items[i];
            }
        }

        public ItemEnum GetEnumerator() => new ItemEnum(items);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
