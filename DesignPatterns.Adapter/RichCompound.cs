using System;

namespace DesignPatterns.Adapter
{
    public class RichCompound : Compound
    {
        // Adapter
        public RichCompound(string name) : base(name)
        {
        }

        public override void Display()
        {
            boilingPoint = ChemicalDatabank.GetCriticalPoint(chemical, "B");
            meltingPoint = ChemicalDatabank.GetCriticalPoint(chemical, "M");
            molecularWeight = ChemicalDatabank.GetMolecularWeight(chemical);
            molecularFormula = ChemicalDatabank.GetMolecularStructure(chemical);

            base.Display();
            Console.WriteLine($" Formula: {molecularFormula}");
            Console.WriteLine($" Weight : {molecularWeight}");
            Console.WriteLine($" Melting Pt: {meltingPoint}");
            Console.WriteLine($" Boiling Pt: {boilingPoint}");
        }
    }
}
