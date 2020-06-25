using System;
using DesignPatterns.AbstractFactory;
using DesignPatterns.AbstractFactory.Factories;

namespace ConsoleUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            FactoryDemo();


            _ = Console.ReadLine();
        }

        private static void FactoryDemo()
        {
            var africa = new AfricaFactory();
            var world = new AnimalWorld(africa);

            world.RunFoodChain();

            var america = new AmericaFactory();
            world = new AnimalWorld(america);

            world.RunFoodChain();
        }
    }
}
