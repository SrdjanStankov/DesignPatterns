using DesignPatterns.AbstractFactory.Carnivores;
using DesignPatterns.AbstractFactory.Herbivores;

namespace DesignPatterns.AbstractFactory.Factories
{
    public class AfricaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore() => new Lion();
        public override Herbivore CreateHerbivore() => new Wildebeest();
    }
}
