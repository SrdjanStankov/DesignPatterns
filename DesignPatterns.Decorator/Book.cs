using System;

namespace DesignPatterns.Decorator
{
    public class Book : LibraryItem
    {
        private string author;
        private string title;

        public Book(string author, string title, int numCopies)
        {
            this.author = author;
            this.title = title;
            NumCopies = numCopies;
        }

        public override void Display()
        {
            Console.WriteLine("\nBook ------ ");
            Console.WriteLine($" Author: {author}");
            Console.WriteLine($" Title: {title}");
            Console.WriteLine($" # Copies: {NumCopies}");
        }
    }
}
