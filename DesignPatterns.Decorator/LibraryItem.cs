namespace DesignPatterns.Decorator
{
    public abstract class LibraryItem
    {
        public int NumCopies { get; set; }

        public abstract void Display();
    }
}
