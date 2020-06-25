using System.Collections.Generic;
using DesignPatterns.Factory.Pages;

namespace DesignPatterns.Factory.Documents
{
    public abstract class Document
    {
        public List<Page> Pages { get; } = new List<Page>();

        protected Document()
        {
            CreatePages();
        }

        public abstract void CreatePages();
    }
}
