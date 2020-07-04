using System;

namespace DesignPatterns.Adapter
{
    public class Compound
    {
        protected string chemical;
        protected float boilingPoint;
        protected float meltingPoint;
        protected double molecularWeight;
        protected string? molecularFormula;

        public Compound(string chemical)
        {
            this.chemical = chemical;
        }

        public virtual void Display() => Console.WriteLine($"Compound: {chemical} ------ ");
    }
}
