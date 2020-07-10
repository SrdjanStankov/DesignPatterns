using System;

namespace DesignPatterns.State
{
    public class Account
    {
        public string Owner { get; }
        public double Balance => State.Balance;
        public State State { get; set; }

        public Account(string owner)
        {
            Owner = owner;
            State = new SilverState(0.0, this);
        }

        public void Deposit(double amount)
        {
            State.Deposit(amount);
            Console.WriteLine($"Deposited {amount:C} --- ");
            Console.WriteLine($" Balance = {Balance:C}");
            Console.WriteLine($" Status = {State.GetType().Name}");
            Console.WriteLine("");
        }

        public void Withdraw(double amount)
        {
            State.Withdraw(amount);
            Console.WriteLine($"Withdrew {amount:C} --- ", amount);
            Console.WriteLine($" Balance = {Balance:C}", Balance);
            Console.WriteLine($" Status = {State.GetType().Name}\n");
        }

        public void PayInterest()
        {
            State.PayInterest();
            Console.WriteLine("Interest Paid --- ");
            Console.WriteLine($" Balance = {Balance:C}", Balance);
            Console.WriteLine($" Status = {State.GetType().Name}\n");
        }
    }
}
