using System.Collections.Generic;

namespace DesignPatterns.Flyweight
{
    public class CharacterFactory
    {
        private Dictionary<char, Character> characters = new Dictionary<char, Character>();

        public Character GetCharacter(char key)
        {
            if (characters.ContainsKey(key))
            {
                return characters[key];
            }

            Character character = key switch
            {
                'A' => new CharacterA(),
                'B' => new CharacterB(),
                'Z' => new CharacterZ(),
                _ => null,
            };
            characters.Add(key, character);
            return character;
        }
    }
}
