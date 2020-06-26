using System;
using DesignPatterns.AbstractFactory;
using DesignPatterns.AbstractFactory.Factories;
using DesignPatterns.Adapter;
using DesignPatterns.Bridge;
using DesignPatterns.Builder;
using DesignPatterns.Builder.Builders;
using DesignPatterns.Composite;
using DesignPatterns.Decorator;
using DesignPatterns.Facade;
using DesignPatterns.Factory.Documents;
using DesignPatterns.Flyweight;
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
            AdapterDemo();
            Console.WriteLine("------------------------------------------------------");
            BridgeDemo();
            Console.WriteLine("------------------------------------------------------");
            CompositeDemo();
            Console.WriteLine("------------------------------------------------------");
            DecoratorDemo();
            Console.WriteLine("------------------------------------------------------");
            FacadeDemo();
            Console.WriteLine("------------------------------------------------------");
            FlyweightDemo();
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
            var b1 = LoadBalancer.instance;
            var b2 = LoadBalancer.instance;
            var b3 = LoadBalancer.instance;
            var b4 = LoadBalancer.instance;

            // Same instance?
            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Same instance\n");
            }

            // Load balance 15 server requests
            var balancer = LoadBalancer.instance;
            for (var i = 0; i < 15; i++)
            {
                var server = balancer.Server;
                Console.WriteLine($"Dispatch Request to: {server}");
            }
        }

        private static void AdapterDemo()
        {
            // Non-adapted chemical compound
            var unknown = new Compound("Unknown");
            unknown.Display();

            // Adapted chemical compounds
            Compound water = new RichCompound("Water");
            water.Display();

            Compound benzene = new RichCompound("Benzene");
            benzene.Display();

            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();
        }

        private static void BridgeDemo()
        {
            var customers = new Customers("Chicago")
            {
                Data = new CustomersData()
            };

            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Henry Velaskeza");

            customers.ShowAll();
        }

        private static void CompositeDemo()
        {
            var root = new CompositeElement("Picture");
            root.Add(new PrimitiveElement("Red Line"));
            root.Add(new PrimitiveElement("Blue Circle"));
            root.Add(new PrimitiveElement("Green Box"));

            // Create a branch
            var comp = new CompositeElement("Two Circles");
            comp.Add(new PrimitiveElement("Black Circle"));
            comp.Add(new PrimitiveElement("White Circle"));
            root.Add(comp);

            // Add and remove a PrimitiveElement
            var pe = new PrimitiveElement("Yellow Line");
            root.Add(pe);
            root.Remove(pe);

            // Recursively display nodes
            root.Display(1);
        }

        private static void DecoratorDemo()
        {
            var book = new Book("Worley", "Inside ASP.NET", 10);
            book.Display();

            Video video = new Video("Spielberg", "Jaws", 23, 92);
            video.Display();

            Console.WriteLine("\nMaking video borrowable:");

            Borrowable borrowvideo = new Borrowable(video);
            borrowvideo.BorrowItem("Customer #1");
            borrowvideo.BorrowItem("Customer #2");

            borrowvideo.Display();
        }

        private static void FacadeDemo()
        {
            // Evaluate mortgage eligibility for customer
            Customer customer = new Customer("Ann McKinsey");
            bool eligible = Mortgage.IsEligible(customer, 125000);

            Console.WriteLine($"\n{customer.Name} has been {(eligible ? "Approved" : "Rejected")}");
        }

        private static void FlyweightDemo()
        {
            string document = "AAZZBBZB";
            char[] chars = document.ToCharArray();

            var factory = new CharacterFactory();
            int pointSize = 10;

            foreach (char c in chars)
            {
                pointSize++;
                Character character = factory.GetCharacter(c);
                character.Display(pointSize);
            }
        }
    }
}
