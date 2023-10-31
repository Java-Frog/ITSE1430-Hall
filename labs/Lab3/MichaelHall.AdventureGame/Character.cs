using System.ComponentModel.DataAnnotations;

namespace MichaelHall.AdventureGame
{
    public class Character
    {
        /// <summary>
        /// Get/Set Character name
        /// </summary>
        public string Name { get; set; }
        //[Required(ErrorMessage = "Name is required")]

        /// <summary>
        /// Get/Set Characters Profession
        /// </summary>
        public string Profession { get; set; }
        //[Required(ErrorMessage = "Profession is required")]

        /// <summary>
        /// Get/Set Characters Race
        /// </summary>
        public string Race { get; set; }
        //[Required(ErrorMessage = "Race is required")]

        /// <summary>
        /// Get/Set Character Biography
        /// </summary>
        public string Biography { get; set; }

        /// <summary>
        /// Get/Set Characters Strength score
        /// </summary>
        public int Strength { get; set; } = 50;

        /// <summary>
        /// Get/Set Intelligence score
        /// </summary>
        public int Intelligence { get; set; } = 50;

        /// <summary>
        /// Get/Set Agility score
        /// </summary>
        public int Agility { get; set; } = 50;

        /// <summary>
        /// Get/Set Constitution score
        /// </summary>
        public int Constitution { get; set; } = 50;

        /// <summary>
        /// Get/Set Charisma score
        /// </summary>
        public int Charisma { get; set; } = 50;

        /// <summary>
        /// Gets the minimum value for attribute scores
        /// </summary>

        public int MinStatValue { get; } = 50;

        /// <summary>
        /// Get gets the maximum value for attribute scores.
        /// </summary>
        public int MaxStatValue { get; } = 100;

        //Methods
        /// <summary>
        /// Removes all values for the associated instance of the class.
        /// </summary>
        public void DeleteCharacter()
        {
            Name = null;
            Profession = null;
            Race = null;
            Biography = null;
            Strength = 0;
            Intelligence = 0;
            Agility = 0;
            Constitution = 0;
            Charisma = 0;
        }

        public void Validate()
        {
            if (Name != null) { }
            if (Profession != null) { }
            if (Race != null) { }
            if (Strength != 50) { }
            if (Constitution != 50) { }
            if (Charisma != 50) { }
            if (Intelligence != 50) { }

        }

        public override string ToString()
        {
            return Name + " " + Race + " " + Profession;

        }
    }
}