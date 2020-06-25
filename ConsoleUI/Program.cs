﻿using System;
using DesignPatterns.AbstractFactory;
using DesignPatterns.AbstractFactory.Factories;
using DesignPatterns.Builder;
using DesignPatterns.Builder.Builders;
using DesignPatterns.Factory.Documents;
using DesignPatterns.Prototype;
using DesignPatterns.Singleton;

namespace ConsoleUI
{
    internal class Program
    {
        private static void Main()
        {
            AbstractFactoryDemo();
            Console.WriteLine("------------------------------------------------------");
            BuilderDemo();
            Console.WriteLine("------------------------------------------------------");
            FactoryDemo();
            Console.WriteLine("------------------------------------------------------");
            PrototypeDemo();
            Console.WriteLine("------------------------------------------------------");
            SingletonDemo();
            Console.WriteLine("------------------------------------------------------");


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

        private static void FactoryDemo()
        {
            var documents = new Document[2]
            {
                new Resume(),
                new Report()
            };

            foreach (var document in documents)
            {
                Console.WriteLine($"\n{document.GetType().Name}--");
                foreach (var page in document.Pages)
                {
                    Console.WriteLine($" {page.GetType().Name}");
                }
            }
        }

        private static void PrototypeDemo()
        {
            var colormanager = new ColorManager()
            {
                ["red"] = new Color(255, 0, 0),
                ["green"] = new Color(0, 255, 0),
                ["blue"] = new Color(0, 0, 255),

                ["angry"] = new Color(255, 54, 0),
                ["peace"] = new Color(128, 211, 128),
                ["flame"] = new Color(211, 34, 20)
            };

            // User clones selected colors
            _ = colormanager["red"].Clone();
            _ = colormanager["peace"].Clone();
            _ = colormanager["flame"].Clone();
        }

        private static void SingletonDemo()
        {
            var b1 = LoadBalancer.GetLoadBalancer();
            var b2 = LoadBalancer.GetLoadBalancer();
            var b3 = LoadBalancer.GetLoadBalancer();
            var b4 = LoadBalancer.GetLoadBalancer();

            // Same instance?
            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Same instance\n");
            }

            // Load balance 15 server requests
            var balancer = LoadBalancer.GetLoadBalancer();
            for (var i = 0; i < 15; i++)
            {
                var server = balancer.Server;
                Console.WriteLine($"Dispatch Request to: {server}");
            }
        }
    }
}
