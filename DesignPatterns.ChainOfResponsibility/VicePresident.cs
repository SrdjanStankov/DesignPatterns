using System;

namespace DesignPatterns.ChainOfResponsibility
{
    public class VicePresident : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 25000.0)
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
