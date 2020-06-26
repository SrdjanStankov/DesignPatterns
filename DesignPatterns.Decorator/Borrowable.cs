using System;
using System.Collections.Generic;

namespace DesignPatterns.Decorator
{
    public class Borrowable : Decorator
    {
        protected List<string> borrowers = new List<string>();

        public Borrowable(LibraryItem libraryItem) : base(libraryItem)
        {
        }

        public void BorrowItem(string name)
        {
            borrowers.Add(name);
            libraryItem.NumCopies--;
        }

        public void ReturnItem(string name)
        {
            _ = borrowers.Remove(name);
            libraryItem.NumCopies++;
        }

        public override void Display()
        {
            base.Display();

            foreach (var borrower in borrowers)
            {
                Console.WriteLine($" borrower: {borrower}");
            }
        }
    }
}
