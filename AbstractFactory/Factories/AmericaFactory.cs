using DesignPatterns.AbstractFactory.Carnivores;
using DesignPatterns.AbstractFactory.Herbivores;

namespace DesignPatterns.AbstractFactory.Factories
{
    public class AmericaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore() => new Bison();
        public override Carnivore CreateCarnivore() => new Wolf();
    }
}
