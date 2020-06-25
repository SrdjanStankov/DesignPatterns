using System.Collections.Generic;

namespace DesignPatterns.Prototype
{
    public class ColorManager
    {
        private Dictionary<string, ColorPrototype> colors = new Dictionary<string, ColorPrototype>();

        // Indexer
        public ColorPrototype this[string key]
        {
            get => colors[key];
            set => colors.Add(key, value);
        }
    }
}
