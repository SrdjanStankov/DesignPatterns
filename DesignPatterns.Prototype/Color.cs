using System;

namespace DesignPatterns.Prototype
{
    public class Color : ColorPrototype
    {
        public int Red { get; }
        public int Green { get; }
        public int Blue { get; }

        public Color(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public override ColorPrototype? Clone()
        {
            Console.WriteLine($"Cloning color RGB: {Red,3},{Green,4},{Blue,4}");
            return MemberwiseClone() as ColorPrototype;
        }
    }
}
