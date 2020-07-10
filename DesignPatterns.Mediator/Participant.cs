using System;

namespace DesignPatterns.Mediator
{
    public class Participant
    {
        public Chatroom? Chatroom { set; get; }

        public string Name { get; }

        public Participant(string name)
        {
            Name = name;
        }

        public void Send(string to, string message) => Chatroom?.Send(Name, to, message);

        public virtual void Receive(string from, string message) => Console.WriteLine($"{from} to {Name}: '{message}'");
    }
}
