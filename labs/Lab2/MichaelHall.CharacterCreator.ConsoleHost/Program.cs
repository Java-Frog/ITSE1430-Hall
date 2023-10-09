/* UI FILE
 * Michael Hall
 * ITSE 1430-2023 FALL
 * Lab 2 - Character Creator
 * Due Oct 10, 2024
 */

using MichaelHall.CharacterCreator;


class Program
{
    static void Main(string[] args)
    {
        var app = new Program();
        app.Run();
    }

    int Run()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Michael A. Hall\nITSE 1430 - Fall 2023\nLab 2 - Character Creator\n");
        Console.ResetColor();
        int menuOption;
        Character playerCharacter = null;
        //Entry Point
        do
        {
            //Case 1 - New Character, Case 2 - Edit Character, Case 3 - Delete Character, Case 4 - Display Character, Case 5 - Exit Program
            menuOption = MainMenu();
            switch (menuOption)
            {
                case 1: playerCharacter = CreateCharacter(); break; 
                case 2:
                    {
                        if (playerCharacter != null)
                        {
                            EditCharacter(ref playerCharacter);
                        }
                        else
                        {
                            playerCharacter = CreateCharacter();
                        }
                        break;
                    }
                case 3:
                    {
                        if (playerCharacter != null && Confirmation("Are you sure you want to delete your character?[Y]es or [N]o"))
                        {
                            playerCharacter.DeleteCharacter();
                            playerCharacter = null;
                            Console.WriteLine("Character Deleted");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("No character to delete.");
                        }
                        break;
                    }
                case 4:
                    {
                        if (playerCharacter != null)
                        {
                            DisplayCharacter(playerCharacter);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("No character to display. Please create a character first.");
                        }
                        break;
                    }
                case 5:
                    {
                        if (Confirmation("Are you sure you want to quit? [Y]es or [N]o"))
                            return 0;
                        Console.Clear();
                        break;
                    }
            }
        } while (true);
    }
    
    //Functions

    
    /// <summary>
    /// Main menu display and navigation
    /// </summary>
    /// <returns>int values corresponding to user menu choice</returns>
    static int MainMenu()
    {
        Console.WriteLine("".PadLeft(20, '-'));
        Console.WriteLine("Main Menu");
        Console.WriteLine("".PadLeft(20, '-'));
        Console.WriteLine("[C] - Create Character");
        Console.WriteLine("[E] - Edit Character");
        Console.WriteLine("[D] - Delete Character");
        Console.WriteLine("[V] - View Character");
        Console.WriteLine("[X] - Exit");
        do
        {
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.C: return 1;
                case ConsoleKey.E: return 2;
                case ConsoleKey.D: return 3;
                case ConsoleKey.V: return 4;
                case ConsoleKey.X: return 5;
                default: Console.WriteLine("Invalid Selection. Try again"); break;
            }
        } while (true);
    }

    /// <summary>
    /// Passed a message, requests user to enter a response, trims the user response, and validates if the data is required or not.
    /// </summary>
    /// <param name="message"></param>
    /// <param name="isRequired"></param>
    /// <returns>String containing requested user input</returns>
    static string ReadString(string message, bool isRequired)
    {
        Console.WriteLine(message);
        do
        {
            string value = Console.ReadLine().Trim();
            if (!isRequired || !String.IsNullOrEmpty(value))
                return value;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Value is required");
            Console.ResetColor();
        } while (true);
    }
    /// <summary>
    /// Displays and validates user selection for character profession
    /// </summary>
    /// <param name="message"></param>
    /// <returns> string of user selected profession choice</returns>
    static string ValidateProfession(string message)
    {
        Console.WriteLine(message);
        do
        {
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.F: return "Fighter";
                case ConsoleKey.H: return "Hunter";
                case ConsoleKey.P: return "Priest";
                case ConsoleKey.R: return "Rogue";
                case ConsoleKey.W: return "Wizard";
                default: Console.WriteLine("Invalid Selection, please try again."); break;
            }
        } while (true);
    }

    /// <summary>
    /// Displays and validates user choice for character race
    /// </summary>
    /// <param name="message"></param>
    /// <returns>string containing user selected race choice</returns>
    static string ValidateRace(string message)
    {
        Console.WriteLine(message);
        while (true)
        {
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.E: return "Elf";
                case ConsoleKey.H: return "Human";
                case ConsoleKey.D: return "Dwarf";
                case ConsoleKey.O: return "Orc";
                case ConsoleKey.G: return "Gnome";
                default: Console.WriteLine("Invalid Selection, please try again."); break;
            }
        }
    }

    /// <summary>
    /// Validates values for character stats (strength, intelligence, ect)
    /// </summary>
    /// <param name="message"></param>
    /// <param name="playerCharacter"></param>
    /// <returns>int with validated values for stats</returns>
    static int ValidateStats(string message, Character playerCharacter)
    {
        Console.WriteLine(message);
        do
        {
            string value = Console.ReadLine();
            if (Int32.TryParse(value, out var result))
                if (result >= playerCharacter.MinStatValue && result <= playerCharacter.MaxStatValue)
                    return result;
            Console.WriteLine($"Invalid value. Please enter a value between {playerCharacter.MinStatValue} and {playerCharacter.MaxStatValue}.");
        } while (true);
    }
    
    /// <summary>
    /// Displays a confirmation message before a user deletes a character, or exits the program.
    /// </summary>
    /// <param name="message"></param>
    /// <returns>Boolean, true if user accepts, or false if they decline.</returns>
    static bool Confirmation(string message)
    {
        Console.WriteLine(message);
        if (Console.ReadKey(true).Key == ConsoleKey.Y)
        {
            return true;
        }
        return false;
    }

    /// <summary>
    /// Displays current character, provides the user with a menu to select which attributes they want to change. Updates display to show changes.
    /// </summary>
    /// <param name="playerCharacter"></param>
    /// <returns>Character class instance with the updated attributes</returns>
    static Character EditCharacter(ref Character playerCharacter)
    {
        do
        {
            Console.Clear();
            DisplayCharacter(playerCharacter);
            Console.WriteLine("".PadLeft(20, '-'));
            Console.WriteLine("What would you like to change?");
            Console.WriteLine("".PadLeft(20, '-'));

            Console.WriteLine("1.) Name\n2.) Profession\n3.) Race\n4.) Biography\n5.) Strength\n6.) Intelligence\n7.) Agility\n8.) Constitution\n9.) Charisma\n0.) Save Changes");

            ConsoleKey key = Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.D1:
                    playerCharacter.CharacterName = ReadString("Enter the character's name: ", true); break;
                case ConsoleKey.D2:
                    playerCharacter.CharacterProfession = ValidateProfession("Enter your character's profession: [F]ighter, [H]unter, [P]riest, [R]ogue, [W]izard"); break;
                case ConsoleKey.D3:
                    playerCharacter.CharacterRace = ValidateRace("Enter character race ([H]uman, [E]lf, [D]warf, [O]rc, [G]nome): "); break;
                case ConsoleKey.D4:
                    playerCharacter.CharacterBiography = ReadString("Enter the character's biography: ", false); break;
                case ConsoleKey.D5:
                    playerCharacter.Strength = ValidateStats($"Enter the Strength score between {playerCharacter.MinStatValue} and {playerCharacter.MaxStatValue} : ", playerCharacter); break;
                case ConsoleKey.D6:
                    playerCharacter.Intelligence = ValidateStats($"Enter the Intelligence score between {playerCharacter.MinStatValue} and {playerCharacter.MaxStatValue} : ", playerCharacter); break;

                case ConsoleKey.D7:
                    playerCharacter.Agility = ValidateStats($"Enter the Agility score between {playerCharacter.MinStatValue} and {playerCharacter.MaxStatValue} : ", playerCharacter); break;

                case ConsoleKey.D8:
                    playerCharacter.Constitution = ValidateStats($"Enter the Constitution score between {playerCharacter.MinStatValue} and {playerCharacter.MaxStatValue} : ", playerCharacter); break;

                case ConsoleKey.D9:
                    playerCharacter.Charisma = ValidateStats($"Enter the Charisma score between {playerCharacter.MinStatValue} and {playerCharacter.MaxStatValue} : ", playerCharacter); break;

                case ConsoleKey.D0:
                    Console.Clear();
                    return playerCharacter;
                default:
                    Console.WriteLine("Invalid selection, please try again.");
                    break;
            }
        } while (true);

    }

    /// <summary>
    /// Creates a new instance of the Character class. Prompts user to fill out attributes with validated data.
    /// </summary>
    /// <returns> completed character instance</returns>
    static Character CreateCharacter()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("".PadLeft(20, '-'));
        Console.WriteLine("Create-A-Character");
        Console.WriteLine("".PadLeft(20, '-'));
        Console.ResetColor();

        Character newCharacter = new Character();
        newCharacter.CharacterName = ReadString("Enter the character's name: ", true);
        newCharacter.CharacterProfession = ValidateProfession("Enter your character's profession: [F]ighter, [H]unter, [P]riest, [R]ogue, [W]izard");
        newCharacter.CharacterRace = ValidateRace("Enter character race ([H]uman, [E]lf, [D]warf, [O]rc, [G]nome): ");
        newCharacter.CharacterBiography = ReadString("Enter the character's biography: ", false);
        newCharacter.Strength = ValidateStats($"Enter the Strength score between {newCharacter.MinStatValue} and {newCharacter.MaxStatValue} : ", newCharacter);
        newCharacter.Intelligence = ValidateStats($"Enter the Intelligence score between {newCharacter.MinStatValue} and {newCharacter.MaxStatValue} : ", newCharacter);
        newCharacter.Agility = ValidateStats($"Enter the Agility score between {newCharacter.MinStatValue} and {newCharacter.MaxStatValue} : ", newCharacter);
        newCharacter.Constitution = ValidateStats($"Enter the Constitution score between {newCharacter.MinStatValue} and {newCharacter.MaxStatValue} : ", newCharacter);
        newCharacter.Charisma = ValidateStats($"Enter the Charisma score between {newCharacter.MinStatValue} and {newCharacter.MaxStatValue} : ", newCharacter);
        Console.Clear();
        return newCharacter;
    }

    /// <summary>
    /// Displays the attributes of the passed Character instance
    /// </summary>
    /// <param name="playerCharacter"></param>
    static void DisplayCharacter(Character playerCharacter)
    {
        Console.Clear();
        Console.WriteLine("".PadLeft(20, '-'));
        Console.WriteLine("Character Information:");
        Console.WriteLine("".PadLeft(20, '-'));
        Console.WriteLine($"Name: {playerCharacter.CharacterName}");
        Console.WriteLine($"Profession: {playerCharacter.CharacterProfession}");
        Console.WriteLine($"Race: {playerCharacter.CharacterRace}");
        Console.WriteLine($"Biography: {playerCharacter.CharacterBiography}");
        Console.WriteLine($"Strength: {playerCharacter.Strength}");
        Console.WriteLine($"Intelligence: {playerCharacter.Intelligence}");
        Console.WriteLine($"Agility: {playerCharacter.Agility}");
        Console.WriteLine($"Constitution: {playerCharacter.Constitution}");
        Console.WriteLine($"Charisma: {playerCharacter.Charisma}");
    }
}
