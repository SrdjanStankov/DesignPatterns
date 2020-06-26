using System;

namespace DesignPatterns.Facade
{
    public static class Credit
    {
        public static bool HasGoodCredit(Customer c)
        {
            Console.WriteLine($"Check credit for {c.Name}");
            return true;
        }
    }
}
