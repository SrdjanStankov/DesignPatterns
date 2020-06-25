using DesignPattern.Builder.Builders;

namespace DesignPattern.Builder
{
    public static class Shop
    {
        public static void Construct(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
        }
    }
}
