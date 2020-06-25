using DesignPatterns.AbstractFactory.Carnivores;
using DesignPatterns.AbstractFactory.Factories;
using DesignPatterns.AbstractFactory.Herbivores;

namespace DesignPatterns.AbstractFactory
{
    public class AnimalWorld
    {
        public Herbivore Herbivore { get; set; }
        public Carnivore Carnivore { get; set; }

        public AnimalWorld(ContinentFactory factory)
        {
            Herbivore = factory.CreateHerbivore();
            Carnivore = factory.CreateCarnivore();
        }

        public void RunFoodChain() => Carnivore.Eat(Herbivore);
    }
}