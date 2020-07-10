using System;

namespace DesignPatterns.Observer
{
    public class Investor : IInvestor
    {
        public string Name { get; }
        
        public Investor(string name)
        {
            Name = name;
        }

        public void Update(Stock stock) => Console.WriteLine($"Notified {Name} of {stock.Symbol}'s change to {stock.Price:C}");

    }
}
