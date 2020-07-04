using System;

namespace DesignPatterns.Facade
{
    public static class Bank
    {
        public static bool HasSufficientSavings(Customer c)
        {
            Console.WriteLine($"Check bank for {c.Name}");
            return true;
        }
    }
}
