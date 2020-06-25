using System.Collections.Generic;
using DesignPattern.Factory.Pages;

namespace DesignPattern.Factory.Documents
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
