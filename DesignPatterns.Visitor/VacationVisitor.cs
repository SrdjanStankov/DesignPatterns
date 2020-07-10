using System;

namespace DesignPatterns.Visitor
{
    public class VacationVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            var employee = element as Employee ?? throw new ArgumentNullException(nameof(element));

            employee.VacationDays += 3;
            Console.WriteLine($"{employee.GetType().Name} {employee.Name}'s new vacation days: {employee.VacationDays}");
        }
    }
}
