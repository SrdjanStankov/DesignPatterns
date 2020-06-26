namespace DesignPatterns.Adapter
{
    public static class ChemicalDatabank
    {
        // Old Api
        public static float GetCriticalPoint(string compound, string point) => point == "M"
                ? ((compound.ToLower()) switch
                {
                    "water" => 0.0f,
                    "benzene" => 5.5f,
                    "ethanol" => -114.1f,
                    _ => 0f,
                })
                : ((compound.ToLower()) switch
                {
                    "water" => 100.0f,
                    "benzene" => 80.1f,
                    "ethanol" => 78.3f,
                    _ => 0f,
                });

        public static string GetMolecularStructure(string compound) => (compound.ToLower()) switch
        {
            "water" => "H20",
            "benzene" => "C6H6",
            "ethanol" => "C2H5OH",
            _ => "",
        };

        public static double GetMolecularWeight(string compound) => (compound.ToLower()) switch
        {
            "water" => 18.015,
            "benzene" => 78.1134,
            "ethanol" => 46.0688,
            _ => 0d,
        };
    }
}
