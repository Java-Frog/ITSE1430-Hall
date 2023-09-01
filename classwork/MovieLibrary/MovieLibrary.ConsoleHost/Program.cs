//Movie library to catalog a movie collection
//TODO: Get Movie Data
//--title, genre, descrip, mpaa rating
//--length, release year, budget
//--IsBlackAndWhite
//TODO: Operations Add, edit, view, delete


string genre = "", rating = "";
int length = 0, releaseYear = 1900;
decimal budget = 125.45M;
bool isBlackAndWhite = false;

GetMovie();
DisplayMovie();

//Functions
void GetMovie ()
{
   string title = ReadString("Enter the movie title: ");
   string description = ReadString("Enter the movie description: ");

}
void DisplayMovie ()
{
    Console.WriteLine(title);
    Console.WriteLine(description);
    Console.WriteLine(length);
}

string ReadString(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine();
}
int ReadString ( string message )
{
    Console.WriteLine("Enter the run length (in minutes): ");
    string input = Console.ReadLine();
    return Convert.ToInt32(input);
}