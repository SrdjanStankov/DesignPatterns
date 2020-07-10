using System;

namespace DesignPatterns.Observer
{
    public class Stock
    {
        public string Symbol { get; }
        public double Price { get; private set; }

        protected event Action<Stock> StockUpdate;

        public Stock(string symbol, double price)
        {
            Symbol = symbol;
            Price = price;
            StockUpdate = delegate { };
        }

        public void StartWatching(Action<Stock> action) => StockUpdate += action;

        public void StopWatching(Action<Stock> action) => StockUpdate -= action;

        private void OnStocUpdate() => StockUpdate?.Invoke(this);

        public void UpdatePrice(double amount)
        {
            if (Price != amount)
            {
                Price = amount;
                OnStocUpdate();
            }
        }
    }
}
