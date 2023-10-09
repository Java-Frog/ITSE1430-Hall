/* Business File
 * Michael Hall
 * ITSE 1430-2023 FALL
 * Lab 2 - Character Creator
 * Due Oct 10, 2024
 */


using System;
using System.Collections.Generic;

namespace MichaelHall.CharacterCreator
{
    public class Character
    {
        /// <summary>
        /// Get/Set Character name
        /// </summary>
        public string CharacterName { get; set; }

        /// <summary>
        /// Get/Set Characters Profession
        /// </summary>
        public string CharacterProfession { get; set; }

        /// <summary>
        /// Get/Set Characters Race
        /// </summary>
        public string CharacterRace { get; set; }

        /// <summary>
        /// Get/Set Character Biography
        /// </summary>
        public string CharacterBiography { get; set; }

        /// <summary>
        /// Get/Set Characters Strength score
        /// </summary>
        public int Strength { get; set; }

        /// <summary>
        /// Get/Set Intelligence score
        /// </summary>
        public int Intelligence { get; set; }

        /// <summary>
        /// Get/Set Agility score
        /// </summary>
        public int Agility { get; set; }

        /// <summary>
        /// Get/Set Constitution score
        /// </summary>
        public int Constitution { get; set; }

        /// <summary>
        /// Get/Set Charisma score
        /// </summary>
        public int Charisma { get; set; }

        /// <summary>
        /// Gets the minimum value for attribute scores
        /// </summary>

        public int MinStatValue { get;}

        /// <summary>
        /// Get gets the maximum value for attribute scores.
        /// </summary>
        public int MaxStatValue { get;}

        //Constructor
        /// <summary>
        /// Initializes Character Class, sets up minimum and maximum stat values
        /// </summary>
        public Character()
        {
            // Default constructor
            MinStatValue = 1;
            MaxStatValue = 100;
        }
        
        //Methods
        /// <summary>
        /// Removes all values for the associated instance of the class.
        /// </summary>
        public void DeleteCharacter()
        {
            CharacterName = null;
            CharacterProfession = null;
            CharacterRace = null;
            CharacterBiography = null;
            Strength = 0;
            Intelligence = 0;
            Agility = 0;
            Constitution = 0;
            Charisma = 0;
        }
    }
}
