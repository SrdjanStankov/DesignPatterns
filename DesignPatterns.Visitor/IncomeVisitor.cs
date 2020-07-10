using System;

namespace DesignPatterns.Visitor
{
    public class IncomeVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            var employee = element as Employee ?? throw new ArgumentNullException(nameof(element));

            employee.Income *= 1.10;
            Console.WriteLine($"{employee.GetType().Name} {employee.Name}'s new income: {employee.Income:C}");
        }
    }
}
