namespace DesignPatterns.State
{
    public abstract class State
    {
#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
        protected Account account;
#pragma warning restore CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
        protected double balance;

        protected double interest;
        protected double lowerLimit;
        protected double upperLimit;

        // Properties
        public Account Account
        {
            get => account;
            set => account = value;
        }

        public double Balance
        {
            get => balance;
            set => balance = value;
        }

        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
        public abstract void PayInterest();
    }
}
