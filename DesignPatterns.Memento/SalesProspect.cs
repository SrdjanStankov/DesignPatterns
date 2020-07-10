using System;

namespace DesignPatterns.Memento
{
    public class SalesProspect
    {
        private string? name;
        private string? phone;
        private double budget;

        public string Name
        {
            get => name ?? string.Empty;
            set
            {
                name = value;
                Console.WriteLine("Name:  " + name);
            }
        }

        public string Phone
        {
            get => phone ?? string.Empty;
            set
            {
                phone = value;
                Console.WriteLine("Phone: " + phone);
            }
        }

        public double Budget
        {
            get => budget;
            set
            {
                budget = value;
                Console.WriteLine("Budget: " + budget);
            }
        }

        public Memento SaveMemento()
        {
            Console.WriteLine("\nSaving state --\n");
            return new Memento(name ?? string.Empty, phone ?? string.Empty, budget);
        }

        public void RestoreMemento(Memento memento)
        {
            Console.WriteLine("\nRestoring state --\n");
            Name = memento.Name;
            Phone = memento.Phone;
            Budget = memento.Budget;
        }
    }
}
