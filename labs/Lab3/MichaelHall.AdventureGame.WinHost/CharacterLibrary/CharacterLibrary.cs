using System;
using System.Collections.Generic;
using MichaelHall.AdventureGame;

namespace CharacterDatabase
{
    public class MemoryCharacterDatabase
    {
        private List<Character> characters = new List<Character>();

        public void AddCharacter(Character character)
        {
            // Add the character to your database
            characters.Add(character);
        }

        public void RemoveCharacter(Character character)
        {
            // Remove the character from your database
            characters.Remove(character);
        }

        public List<Character> GetAllCharacters()
        {
            // Return a list of all characters in your database
            return characters;
        }

        public Character GetCharacterByName(string name)
        {
            // Find and return a character by name
            return characters.Find(character => character.Name == name);
        }
    }
}
