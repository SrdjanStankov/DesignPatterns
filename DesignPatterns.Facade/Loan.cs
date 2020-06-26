using System;

namespace DesignPatterns.Facade
{
    public static class Loan
    {
        public static bool HasNoBadLoans(Customer c)
        {
            Console.WriteLine($"Check loans for {c.Name}");
            return true;
        }
    }
}
