/*
 * Michael A. Hall
 * ITSE 1234
 * Fall 2023
 */

//story 2 - Intro to game, should include name, class name (ITSE 1430) and creation date of program.
  void BigWelcomeScreen(string line)
{
    string title = "WELCOME TO THE WORLD OF".PadLeft(50);
    string logo = (@"
                                                                             
                          ,----..                                       ,--. 
    ,---,                /   /   \           ,-.----.               ,--/  /| 
  .'  .' `\             /   .     :          \    /  \           ,---,': / ' 
,---.'     \           .   /   ;.  \         ;   :    \          :   : '/ /  
|   |  .`\  |         .   ;   /  ` ;         |   | .\ :          |   '   ,   
:   : |  '  |         ;   |  ; \ ; |         .   : |: |          '   |  /    
|   ' '  ;  :         |   :  | ; | '         |   |  \ :          |   ;  ;    
'   | ;  .  |         .   |  ' ' ' :         |   : .  /          :   '   \   
|   | :  |  '         '   ;  \; /  |         ;   | |  \          |   |    '  
'   : | /  ;           \   \  ',  /          |   | ;\  \         '   : |.  \ 
|   | '` ,/             ;   :    /           :   ' | \.'         |   | '_\.' 
;   :  .'                \   \ .'            :   : :-'           '   : |     
|   ,.'                   `---`              |   |.'             ;   |,'     
'---'                                        `---'               '---'                                                                    
");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(title);
    Console.WriteLine(line);
    Console.WriteLine(logo);
    Console.WriteLine(line);
    Console.WriteLine("Dimensional Odyssey : The Realms of Kismet\n".PadLeft(58));
    Console.ResetColor();
    Console.WriteLine();
}
void SmallWelcomeScreen(string line)
{
    string title = "D.O.R.K".PadLeft(40);

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(line);
    Console.WriteLine(title);
    Console.WriteLine(line);
    Console.ResetColor();
    Console.WriteLine();
}

void GameIntro(string line)
{
    Console.WriteLine("You've finally escaped the clutches of your daily grind. ");
    Console.WriteLine("Your precious free time has been consumed by mundane tasks: navigating traffic, \npicking up groceries, and diligently chipping away at your ever-growing to-do list.");
    Console.WriteLine("\nBut now, the moment you've been yearning for has arrived – it's time for some well-earned rest.");

    //--------
    TextPause(line);
    Console.WriteLine("As you make your way towards your bed, a strange and unfamiliar sound interrupts your nightly routine.");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("\nDrip\n");
    Console.ResetColor();
    Console.WriteLine("You freeze in your tracks, hoping that it's just a product of your overactive imagination.");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("\nDrip\n");
    Console.ResetColor();

    Console.WriteLine("Reluctantly, you turn your attention to the source of the sound, " +
        "\nonly to discover that your window A/C unit has sprung a leak. . . again." +
        "\r\n\r\nYou decide to continue your routine, all the while mentally adding this new problem to the ever-expanding list of issues that await you tomorrow. " +
        "\nYou lay your head down on your pillow, still thinking about your list. The rhythmic dripping of your A/C unit lulls you into a fitful sleep.");
    //--------
    TextPause(line);
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("\nDrip.\r\nDrip.\r\nDrip.\r\nDrip.\n");
    Console.ResetColor();
    Console.WriteLine("Suddenly, your eyes snap open, and you find yourself in an unfamiliar and dimly lit smooth stone room.\n");
    Console.WriteLine("You gather you whits and start to take in your surroundings.");
    TextPause(line);

    
}


bool Confirm(string message)
{
    return ReadBoolean(message);
}

bool ReadBoolean(string message)
{
    Console.WriteLine(message);
    while(true)
    {
        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.Y: return true;
            case ConsoleKey.N: return false;
        }
    }
}

void TextPause(string line)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine();
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
    Console.WriteLine(line);
    Console.ResetColor();
}

void Room0()
{
    string roomDescription = "You are alone in a room. The only features here are a pair of imposing marble statues holding up a large tapestry.\n";
    string option1 = "1.) - Head North, approaching the statues.\n";
    string option2 = "2.) - Search the room for any other options.\n";
    bool roomChange = false;

    Console.WriteLine(roomDescription);

    do
    {
        Console.WriteLine(option1);
        Console.WriteLine(option2);
        Console.WriteLine("What do you do?\n");
        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.D1:
            {
                Console.WriteLine("As you approach the statues, you notice that what they hold up is not a tapestry. It appears to be a swirling mass of some kind of dark inky liquid.");
                if (Confirm("\nDo you touch the liquid?[Y/N]"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("An unknown force pulls you through the liquid. Everything goes black.\n");
                    Console.ResetColor();
                    Console.WriteLine();
                    roomChange = true;
                    break;
                } else
                {
                    Console.WriteLine("\nYou pull your hand back before you make contact with the ungulating substance.\n");
                    break;
                }
            }
            case ConsoleKey.D2:
            {
                Console.WriteLine("You search the room for what feels like hours. You only know two things for sure now. You really are alone in this room, and the only way out may be related to those statues.\n");
                break;
            }

        }
    } while (!roomChange);


}
void Room1()
{
    char playerInput;
    string roomDiscription = "A cleaned and polished subway station appears around you. The smell of industrial cleaner is prevelant in this space. What do you do?";
    string option1 = "To your [N]orth a train has pulled into the station. Its doors open, revealing a train attendant waiting to take riders tickets.";
    string option2 = "To your [E]ast you see a stairway leading down.";
    string option3 = "To your [W]est is nothing but trash can, and the cleanly scrubbed subway tile wall";
    string option4 = "To your [S]outh you can see a stairway leading up.";
    string roomEvent = "As you look around the station, you step in something sticky. A fresh train ticket has stuck to your shoe.";
    bool eventKey = false;
    bool roomChange = false;

    DisplayOptions(roomDiscription, option1, option2, option3, option4);
    do
    {
        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.N:
            {
                Console.WriteLine("As you approach the attendent reaches out his hand, asking for your ticket.");
                if (eventKey)
                {
                    Console.WriteLine("You present your ticket, which is swiftly punched. The attendent grabs you by the wrist and pulls you into the passenger car. The doors snap behind you.");
                    return;

                } else
                {
                    Console.WriteLine("Ticket please! If you dont have a ticket, please make room for paying customers.");
                    break;
                }
            }

            case ConsoleKey.E:
            {
                Console.WriteLine("You exit the room using the stairs to the East.");
                roomChange=true;
                
                break;
            }

            case ConsoleKey.W:
            {
                Console.WriteLine("You approach the trash can. Like the rest of the room, it has been scrubbed clean.");
                break;
            }

            case ConsoleKey.S:
            {
                Console.WriteLine("You take the stairs leading up and out of the station.");
                roomChange=true;
                break;
            }

        }
    } while (roomChange);
}

void Room2 () { }
void Room3 () { }
void Room4 () { }
void Room5 () { }
void Room6 () { }
void Room7 () { }
void Room8 () { }
void Room9 () { }



void DisplayOptions(string roomDescription,string option1,  string option2, string option3, string option4)
{
    Console.WriteLine(roomDescription);
    Console.WriteLine(option1 + "\n" + option2 + "\n" +option3+ "\n" +option4);

}
//-----Main-----
string dottedLine = new string('-', 85);
BigWelcomeScreen(dottedLine);
if(!Confirm("Are you ready to begin your adventure? [Y/N]"))
{
    Console.WriteLine("Thank you for playing D.O.R.K\nGoodbye.");
    return;
}
Console.Clear();
SmallWelcomeScreen(dottedLine);
GameIntro(dottedLine);
Room0();


//story 3 - Game loop. Create a menu. Case shouldnt matter, seperate functions for each command,
//do NOT recursively call the game loop, double check for spelling errors
//Game loop only closes when the player prompts it to end, validate user input

//story 4 - Quit command, with quit confirmation

//story 5 - Design the game world. Plan out the 3x3 grid. Only rooms adjacent to each other can be reached.

//story 6 - Moving between rooms, display current player room and confirm player positions in new rooms, player location maybe tracked by a 2d array?

//story 7 - Room descriptions, what exits are available, suggesting seperate function for each room.

//story 8 - random encounters %5 chance, function given in instructions

