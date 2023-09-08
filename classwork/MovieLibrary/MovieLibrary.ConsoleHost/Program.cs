// Movie data:
//  Title, genre, description, mpaa rating
//  Length, release year, budget
//  IsBlackAndWhite
// Operations: Add, edit, view, delete

using System.Data;

string title = "", description = "";
//title = "";
string genre = "", rating = "";

int length = 0, releaseYear = 1900;

decimal budget = 125.45M;
bool isBlackAndWhite = false;


//Entry Point
var done = false;
do
{
    switch (DisplayMenu()) 
        //Switch statementsOnly works when comparing the exact same value against different results. IE, the returned value from the DisplayMenu() function
        //No fallthrough on C# switch statements. requires break; , or return statement if in a function, after every case statement
    {
        case 1: AddMovie(); break;
        case 2: EditMovie(); break;
        case 3: DeleteMovie(); break;
        case 4: ViewMovie(); break;
        case 0:
        {
            //can use code blocks in switch statements
            done = true; 
            break;
        }
        default: Console.WriteLine("Invalid Selection"); break;
    }
} while (!done);





/// Functions

void EditMovie ()
{
    Console.WriteLine("Not Implemented");
}

void DeleteMovie()
{
    if (!Confirm("Are you sure you want to delete the movie? (Y/N): "))
        return;
    Console.WriteLine("Not implimented yet");
}
int DisplayMenu ()
{
    Console.WriteLine("-----------------");
    Console.WriteLine("A)dd Movie");
    Console.WriteLine("E)dit Movie");
    Console.WriteLine("D)elete Movie");
    Console.WriteLine("V)iew Movie");
    Console.WriteLine("Q)uit");
    Console.WriteLine("-----------------");

    do
    {
        //var input = Console.ReadLine();
        //if (input == "A" || input =="a")
        //    return 1;
        //else if (input == "E" ||input =="e")
        //    return 2;
        //else if (input == "D"||input =="d")
        //    return 3;
        //else if (input == "V"||input =="v")
        //    return 4;
        //else if (input == "Q"||input == "q")
        //    return 0;

        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.A: return 1;
            case ConsoleKey.E: return 2;
            case ConsoleKey.D: return 3;
            case ConsoleKey.V: return 4;
            case ConsoleKey.Q: return 0;
        }

    } while (true);
}
void AddMovie ()
{
    title = ReadString("Enter a title: ", true);
    description = ReadString("Enter a description: ", false);

    length = ReadInt("Enter the run length (in mins): ", 0);
    releaseYear = ReadInt("Enter the release year: ", 1900);

    genre = ReadString("Enter a genre: ", false);
    rating = ReadRating("Enter a rating: ");

    isBlackAndWhite = ReadBoolean("Black and White (Y/N)?");
}

void ViewMovie ()
{
    Console.WriteLine("\n--------------");//escape characters \n \t \" \' \\
    //verbatim strings use a @ before the value. filePath = @"C:\windows\temp"; || filePath = """   """; <--Raw String

    Console.WriteLine(title);

    //Run Length: ## mins
    Console.WriteLine("Run Length: " + length + " mins");

    //Released yyyy
    Console.WriteLine("Released " + releaseYear);

    Console.WriteLine(genre);

    //MPAA Rating: 
    Console.WriteLine("MPAA Rating: " + rating);

    //V2
    string format = isBlackAndWhite ? "Black and White" : "Color";
    Console.WriteLine("Format: " + format);

    //V3
    //Console.WriteLine("Format: " + (isBlackAndWhite ? "Black and White" : "Color"));

    Console.WriteLine(description);
}

bool ReadBoolean (string message )
{
    Console.WriteLine(message);

    //Handle errors
    while (true)
    {
        //string value = Console.ReadLine();
        //var value = Console.ReadLine();
        //if (value == "Y" || value == "y")
        //    return true;
        //else if (value == "N" || value == "n")  // value == "N" || "n"
        //    return false;

        switch (Console.ReadKey(true).Key) //ReadKey(true) keeps the key  entered from being displayed in the console
            //Alternative input command, reads only 1 character from the keyboard, no need for the enter key
            //ConsoleKey.Key removes the upper and lowercase, returns value of the key pressed on the keyboard. ConsoleKey.* is needed to check the value
        {
            case ConsoleKey.Y: return true;
            case ConsoleKey.N: return false;
        }


        //Console.WriteLine("Please enter Y/N");

        ////Stops current iteration, exits loop
        //if (false)
        //    break;

        ////Stops current iteration, loops around and tries again
        //if (false)
        //    continue;
    };
}

bool Confirm (string message )
{
    return ReadBoolean(message);
}

int ReadInt (string message, int minimumValue )
{
    Console.WriteLine(message);

    do
    {
        string value = Console.ReadLine();
        if (Int32.TryParse(value, out var result)) //inline declaration
            if (result >= minimumValue)
                return result;

        Console.WriteLine("Value must be at least " + minimumValue);
    } while (true);
}

string ReadString (string message, bool isRequired )
{
    Console.WriteLine(message);

    do
    {
        string value = Console.ReadLine();

        if (!isRequired || !String.IsNullOrEmpty(value))
            return value;
        //if (!isRequired)
        //    return value;

        ////Is it empty?
        //if (value != "")
        //    return value;

        Console.WriteLine("Value is required");
    } while (true);
}

string ReadRating (string message)
{
    Console.WriteLine(message);

    do
    {
        string value = Console.ReadLine().ToUpper();

        if (value == "PG")
            return "PG";
        else if (value == "G")
            return "G";
        else if (value == "PG-13")
            return "PG-13";
        else if (value == "R")
            return "R";
        else if (String.IsNullOrEmpty(value)) //empty string can also be shown as  value == String.Empty String.IsNullOrEmpty() is the way to check for empty strings
            return "";

        Console.WriteLine("Invalid Rating");
    } while (true);
}