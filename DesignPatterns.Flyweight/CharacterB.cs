using System;

namespace DesignPatterns.Flyweight
{
    public class CharacterB : Character
    {
        public CharacterB()
        {
            symbol = 'B';
            height = 100;
            width = 140;
            ascent = 72;
            descent = 0;
        }

        public override void Display(int pointSize)
        {
            this.pointSize = pointSize;
            Console.WriteLine($"{symbol} (point size {this.pointSize})");
        }
    }
}
