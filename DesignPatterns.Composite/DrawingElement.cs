namespace DesignPatterns.Composite
{
    public abstract class DrawingElement
    {
        protected string name;

        protected DrawingElement(string name)
        {
            this.name = name;
        }

        public abstract void Add(DrawingElement d);
        public abstract void Remove(DrawingElement d);
        public abstract void Display(int indent);
    }
}
