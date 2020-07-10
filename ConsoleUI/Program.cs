using System;
using System.Collections.Generic;
using DesignPatterns.AbstractFactory;
using DesignPatterns.AbstractFactory.Factories;
using DesignPatterns.Adapter;
using DesignPatterns.Bridge;
using DesignPatterns.Builder;
using DesignPatterns.Builder.Builders;
using DesignPatterns.ChainOfResponsibility;
using DesignPatterns.Command;
using DesignPatterns.Composite;
using DesignPatterns.Decorator;
using DesignPatterns.Facade;
using DesignPatterns.Factory.Documents;
using DesignPatterns.Flyweight;
using DesignPatterns.Prototype;
using DesignPatterns.Proxy;
using DesignPatterns.Singleton;
using DesignPatterns.Interpreter;
using DesignPatterns.Iterator;
using DesignPatterns.Mediator;
using DesignPatterns.Memento;
using DesignPatterns.Observer;

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
            ProxyDemo();
            Console.WriteLine("------------------------------------------------------");
            ChainOfResponsibilityDemo();
            Console.WriteLine("------------------------------------------------------");
            CommandDemo();
            Console.WriteLine("------------------------------------------------------");
            InterpreterDemo();
            Console.WriteLine("------------------------------------------------------");
            IteratorDemo();
            Console.WriteLine("------------------------------------------------------");
            MediatorDemo();
            Console.WriteLine("------------------------------------------------------");
            MementoDemo();
            Console.WriteLine("------------------------------------------------------");
            ObserverDemo();
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
                Character? character = factory.GetCharacter(c);
                character?.Display(pointSize);
            }
        }

        private static void ProxyDemo()
        {
            var proxy = new MathProxy();

            Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));
            Console.WriteLine("4 - 2 = " + proxy.Sub(4, 2));
            Console.WriteLine("4 * 2 = " + proxy.Mul(4, 2));
            Console.WriteLine("4 / 2 = " + proxy.Div(4, 2));
        }

        private static void ChainOfResponsibilityDemo()
        {
            Approver larry = new Director();
            Approver sam = new VicePresident();
            Approver tammy = new President();

            larry.SetSuccessor(sam);
            sam.SetSuccessor(tammy);

            // Generate and process purchase requests

            Purchase p = new Purchase(2034, 350.00, "Assets");
            larry.ProcessRequest(p);

            p = new Purchase(2035, 32590.10, "Project X");
            larry.ProcessRequest(p);

            p = new Purchase(2036, 122100.00, "Project Y");
            larry.ProcessRequest(p);
        }

        private static void CommandDemo()
        {
            Invoker invoker = new Invoker(new ConcreteCommand(new Receiver()));

            // Set and execute command
            invoker.SetCommand(new ConcreteCommand(new Receiver()));
            invoker.ExecuteCommand();
        }

        private static void InterpreterDemo()
        {
            var roman = "MCMXXVIII";
            var context = new Context(roman);

            // Build the 'parse tree'
            var tree = new List<Expression>
            {
                new ThousandExpression(),
                new HundredExpression(),
                new TenExpression(),
                new OneExpression()
            };

            // Interpret
            foreach (var exp in tree)
            {
                exp.Interpret(context);
            }

            Console.WriteLine($"{roman} = {context.Output}");
        }

        private static void IteratorDemo()
        {
            var items = new Item[3]
            {
                new Item("Item 0"),
                new Item("Item 1"),
                new Item("Item 2"),
            };

            var itemList = new ItemCollection(items);
            foreach (var item in itemList)
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void MediatorDemo()
        {
            var chatroom = new Chatroom();

            // Create participants and register them

            Participant George = new Beatle("George");
            Participant Paul = new Beatle("Paul");
            Participant Ringo = new Beatle("Ringo");
            Participant John = new Beatle("John");
            Participant Yoko = new NonBeatle("Yoko");

            chatroom.Register(George);
            chatroom.Register(Paul);
            chatroom.Register(Ringo);
            chatroom.Register(John);
            chatroom.Register(Yoko);

            // Chatting participants

            Yoko.Send("John", "Hi John!");
            Paul.Send("Ringo", "All you need is love");
            Ringo.Send("George", "My sweet Lord");
            Paul.Send("John", "Can't buy me love");
            John.Send("Yoko", "My sweet love");
        }

        private static void MementoDemo()
        {
            var s = new SalesProspect
            {
                Name = "Noel van Helen",
                Phone = "(412) 256-0990",
                Budget = 25000.0
            };

            // Store internal state
            var m = new ProspectMemory
            {
                Memento = s.SaveMemento()
            };

            // Continue changing originator
            s.Name = "Leo Welch";
            s.Phone = "(310) 209-7111";
            s.Budget = 1000000.0;

            // Restore saved state

            s.RestoreMemento(m.Memento);
        }

        private static void ObserverDemo()
        {
            var ibm = new IBM("IBM", 120.00);
            var investor1 = new Investor("Sorros");
            var investor2 = new Investor("Berkshire");
            
            ibm.StartWatching(investor1.Update);
            ibm.StartWatching(investor2.Update);

            ibm.UpdatePrice(120.10);
            ibm.UpdatePrice(121.00);
            ibm.StopWatching(investor1.Update);
            ibm.UpdatePrice(120.50);
            ibm.StopWatching(investor2.Update);
            ibm.UpdatePrice(120.75);
        }
    }
}
