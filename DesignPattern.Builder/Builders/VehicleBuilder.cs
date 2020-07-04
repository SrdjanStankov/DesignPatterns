namespace DesignPatterns.Builder.Builders
{
    public abstract class VehicleBuilder
    {
        public Vehicle Vehicle { get; protected set; }

        protected VehicleBuilder(string vehicleType)
        {
            Vehicle = new Vehicle(vehicleType);
        }

        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }
}
