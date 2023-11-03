using System.ComponentModel.DataAnnotations;

namespace MichaelHall.AdventureGame
{
    public class Character : IValidatableObject
    {

        #region Properties

        /// <summary>
        /// Get/Set Character name
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// Get/Set Characters Profession
        /// </summary>
        public string Profession { get; set; }


        /// <summary>
        /// Get/Set Characters Race
        /// </summary>
        public string Race { get; set; }


        /// <summary>
        /// Get/Set Character Biography
        /// </summary>
        public string Biography { get; set; }

        /// <summary>
        /// Get/Set Characters Strength score
        /// </summary>
        public int Strength { get; set; } = MinStatValue;

        /// <summary>
        /// Get/Set Intelligence score
        /// </summary>
        public int Intelligence { get; set; } = MinStatValue;

        /// <summary>
        /// Get/Set Agility score
        /// </summary>
        public int Dexterity { get; set; } = MinStatValue;

        /// <summary>
        /// Get/Set Constitution score
        /// </summary>
        public int Constitution { get; set; } = MinStatValue;

        /// <summary>
        /// Get/Set Charisma score
        /// </summary>
        public int Charisma { get; set; } = MinStatValue;

        /// <summary>
        /// Gets the minimum value for attribute scores
        /// </summary>

        public static int MinStatValue { get; } = 50;

        /// <summary>
        /// Get gets the maximum value for attribute scores.
        /// </summary>
        public static int MaxStatValue { get; } = 100;

        /// <summary>
        /// ID for internal tracking
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// List of valid character professions
        /// </summary>
        public List<string> ProfessionOptions { get; } = new List<string>
        {
            "Fighter",
            "Magic-User",
            "Cleric",
            "Thief",
            "Monk",
            "Paladin",
            "Ranger",
            "Druid",
            "Illusionist",
            "Assassin"
        };

        /// <summary>
        /// List of valid character races
        /// </summary>
        public List<string> RaceOptions { get; } = new List<string>
        {
            "Human",
            "Elf",
            "Dwarf",
            "Gnome",
            "Halfling",
            "Half-Elf",
            "Half-Orc"
        };

        #endregion

        #region Methods


        public bool TryValidate(out string message)
        {
            if (string.IsNullOrEmpty(Name))
            {
                message = "Name is required";
                return false;
            }

            if (string.IsNullOrEmpty(Profession))
            {
                message = "Profession is required";
                return false;
            }

            if (string.IsNullOrEmpty(Race))
            {
                message = "Race is required";
                return false;
            }

            if (Strength < MinStatValue || Strength > MaxStatValue)
            {
                message = $"Strength must be between {MinStatValue} and {MaxStatValue}";
                return false;
            }

            if (Intelligence < MinStatValue || Intelligence > MaxStatValue)
            {
                message = $"Intelligence must be between {MinStatValue} and {MaxStatValue}";
                return false;
            }

            if (Dexterity < MinStatValue || Dexterity > MaxStatValue)
            {
                message = $"Dexterity must be between {MinStatValue} and {MaxStatValue}";
                return false;
            }

            if (Charisma < MinStatValue || Charisma > MaxStatValue)
            {
                message = $"Charisma must be between {MinStatValue} and {MaxStatValue}";
                return false;
            }

            if (Constitution < MinStatValue || Constitution > MaxStatValue)
            {
                message = $"Constitution must be between {MinStatValue} and {MaxStatValue}";
                return false;
            }

            message = "Validation successful";
            return true;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (String.IsNullOrEmpty(Name))
            {
                yield return new ValidationResult("Name is required");
            }
            if (String.IsNullOrEmpty(Race))
            {
                yield return new ValidationResult("Race is required");
            }
            if (String.IsNullOrEmpty(Race))
            {
                yield return new ValidationResult("Race is requierd");
            }
            if (Intelligence > MaxStatValue || Intelligence < MinStatValue)
            {
                yield return new ValidationResult("Intelligence must be >=50, and <=100");
            }

            if (Constitution > MaxStatValue || Constitution < MinStatValue)
            {
                yield return new ValidationResult("Constitution must be >=50, and <=100");
            }

            if (Charisma > MaxStatValue || Charisma < MinStatValue)
            {
                yield return new ValidationResult("Charisma must be >=50, and <=100");
            }

            if (Dexterity > MaxStatValue || Dexterity < MinStatValue)
            {
                yield return new ValidationResult("Agility must be >=50, and <=100");
            }

            if (Strength > MaxStatValue || Strength < MinStatValue)
            {
                yield return new ValidationResult("Strength must be >=50, and <=100");
            }
        }

        public override string ToString()
        {
            return $"{Name} | {Race} | {Profession}";

        }

        #endregion
    }
}