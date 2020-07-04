using System;

namespace DesignPatterns.ChainOfResponsibility
{
    public class Director : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 10000.0)
            {
                Console.WriteLine($"{GetType().Name} approved request# {purchase.Number}");
            }
            else
            {
                successor?.ProcessRequest(purchase);
            }
        }
    }
}
