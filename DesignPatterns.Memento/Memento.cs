namespace DesignPatterns.Memento
{
    public class Memento
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public double Budget { get; set; }

        public Memento(string name, string phone, double budget)
        {
            Name = name;
            Phone = phone;
            Budget = budget;
        }
    }
}
