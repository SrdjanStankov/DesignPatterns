using System;

namespace DesignPatterns.Facade
{
    public static class Mortgage
    {
        // Facade
        public static bool IsEligible(Customer cust, int amount)
        {
            Console.WriteLine($"{cust.Name} applies for {amount:C} loan\n");

            // Check creditworthiness of applicant
            return Bank.HasSufficientSavings(cust) && Loan.HasNoBadLoans(cust) && Credit.HasGoodCredit(cust);
        }
    }
}
