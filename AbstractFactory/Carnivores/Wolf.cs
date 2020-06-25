using System;
using DesignPatterns.AbstractFactory.Herbivores;

namespace DesignPatterns.AbstractFactory.Carnivores
{
    public class Wolf : Carnivore
    {
        public override void Eat(Herbivore herbivore) => Console.WriteLine($"{GetType().Name} eats {herbivore.GetType().Name}");
    }
}