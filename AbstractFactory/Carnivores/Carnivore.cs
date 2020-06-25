using DesignPatterns.AbstractFactory.Herbivores;

namespace DesignPatterns.AbstractFactory.Carnivores
{
    public abstract class Carnivore
    {
        public abstract void Eat(Herbivore herbivore);
    }
}