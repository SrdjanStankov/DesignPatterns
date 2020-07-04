using System;

namespace DesignPatterns.Command
{
    public abstract class Command
    {
        protected Receiver receiver;

        protected Command(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public abstract void Execute();
    }

    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver) : base(receiver)
        {
        }

        public override void Execute() => receiver.Action();
    }

    public class Receiver
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1822:Mark members as static")]
        public void Action() => Console.WriteLine("Called Receiver.Action()");
    }

    public class Invoker
    {
        private Command command;

        public Invoker(Command command)
        {
            this.command = command;
        }

        public void SetCommand(Command command) => this.command = command;

        public void ExecuteCommand() => command.Execute();
    }
}
