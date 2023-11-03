using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;

namespace MichaelHall.AdventureGame.Memory
{
    public class MemoryCharacterDatabase
    {
        private List<Character> _characters = new List<Character>();
        private int _id = 1;

        public MemoryCharacterDatabase()
        {
            //Sample Characters
            var initialCharacters = new List<Character>
            {
                new Character
                {
                    Name = "Jeff",
                    Profession = "Fighter",
                    Race = "Human",
                    Strength = 50,
                    Intelligence = 50,
                    Dexterity = 50,
                    Constitution = 50,
                    Charisma = 50,
                    Id = 1
                },
                new Character
                {
                    Name = "Scott",
                    Profession = "Fighter",
                    Race = "Human",
                    Strength = 50,
                    Intelligence = 50,
                    Dexterity = 50,
                    Constitution = 50,
                    Charisma = 50,
                    Id = 2
                },
                new Character
                {
                    Name = "Larse",
                    Profession = "Fighter",
                    Race = "Human",
                    Strength = 50,
                    Intelligence = 50,
                    Dexterity = 50,
                    Constitution = 50,
                    Charisma = 50,
                    Id = 3
                },
            };

            _characters.AddRange(initialCharacters); // Use AddRange to add the initial characters.

            foreach (var character in initialCharacters)
            {
                Add(character);
            }
        }
        #region Methods

        /// <summary>
        /// Add characters to list
        /// </summary>
        /// <param name="character"></param>
        /// <returns></returns>
        public string Add(Character character)
        {
            if (character == null)
            {
                return "Character is null";
            }

            if (!character.TryValidate(out var error))
            {
                return error;
            }

            var existing = FindByName(character.Name);
            if (existing != null)
            {
                return "Character name must be unique";
            }

            character.Id = _id++;
            _characters.Add(character); // Add the character to the _characters list.
            return "";
        }

        /// <summary>
        /// Updates character 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="character"></param>
        /// <returns></returns>
        public string Update ( int id, Character character)
        {
            if (id <= 0)
                return "ID is invalid";

            if(character == null)
                return "Character is null";

            if(!character.TryValidate(out var error))
            {
                return error;
            }

            var existing = FindByName(character.Name);
            if(existing != null && existing.Id != id)
            {
                return "Character name must be unique";
            }
            existing = FindById(id);
            if (existing == null)
                return "Character not found";

            Copy(existing, character);
            return "";

        }

        /// <summary>
        /// Removes character
        /// </summary>
        /// <param name="id"></param>
        public void Delete (int id)
        {
            var character = FindById(id);
            if (character != null)
                _characters.Remove(character);
        }

        public IEnumerable<Character> GetAll()
        {
            foreach(var character in _characters)
            {
                yield return Clone(character);
            }
        }

        /// <summary>
        /// Copys character data, uses it to make a new character
        /// </summary>
        /// <param name="character"></param>
        /// <returns></returns>
        public Character Clone(Character character)
        {
            var item = new Character() { Id = character.Id };
            Copy(item, character);
            return item;
        }

        /// <summary>
        /// Copys character properties data over to a different target
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        private void Copy (Character target, Character source)
        {
            target.Name = source.Name;
            target.Profession = source.Profession;
            target.Race = source.Race;
            target.Biography = source.Biography;
            target.Intelligence = source.Intelligence;
            target.Strength = source.Strength;
            target.Dexterity = source.Dexterity;
            target.Charisma = source.Charisma; 
            target.Constitution = source.Constitution;
        }

        /// <summary>
        /// Finds character instance by ID#
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private Character FindById (int id)
        {
            foreach (var character in _characters)
                if (character.Id == id)
                    return character;
            
            return null;
        }

        /// <summary>
        /// Finds character instance by character name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private Character FindByName(string name)
        {
            foreach (var character in _characters)
                if ((String.Equals(name, character.Name, StringComparison.OrdinalIgnoreCase)))
                    return character;
            
            return null;
        }

        #endregion
    }

}
