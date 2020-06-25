using System;
using DesignPattern.Builder;
using DesignPattern.Builder.Builders;
using DesignPatterns.AbstractFactory;
using DesignPatterns.AbstractFactory.Factories;

namespace ConsoleUI
{
    internal class Program
    {
        private static void Main()
        {
            AbstractFactoryDemo();
            Console.WriteLine("---------------------------");
            BuilderDemo();
            Console.WriteLine("---------------------------");

            _ = Console.ReadLine();
        }

        private static void AbstractFactoryDemo()
        {
            var africa = new AfricaFactory();
            var world = new AnimalWorld(africa);

            world.RunFoodChain();

            var america = new AmericaFactory();
            world = new AnimalWorld(america);

            world.RunFoodChain();
        }

        private static void BuilderDemo()
        {
            void Builder(VehicleBuilder vehicleBuilder)
            {
                Shop.Construct(vehicleBuilder);
                vehicleBuilder.Vehicle.Show();
            }

            Builder(new ScooterBuilder());
            Builder(new CarBuilder());
            Builder(new MotorCycleBuilder());
        }
    }
}
