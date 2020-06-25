using DesignPatterns.AbstractFactory.Carnivores;
using DesignPatterns.AbstractFactory.Herbivores;

namespace DesignPatterns.AbstractFactory.Factories
{
    public abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }
}