namespace DesignPatterns.Builder.Builders
{
    public abstract class VehicleBuilder
    {
        public Vehicle Vehicle { get; protected set; }

        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }
}
