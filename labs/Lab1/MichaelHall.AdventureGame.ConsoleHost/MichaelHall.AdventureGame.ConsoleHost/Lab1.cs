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
    Console.Clear();
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

int Room0()
{
    string roomDescription = "In this solitary chamber, you stand alone amidst its sparse contents—a pair of grand marble statues steadfastly supporting a colossal tapestry.\nWhat do you do?";
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
                    roomChange = true;
                    return 1;
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
    }while (!roomChange);
    return 0;
}
int Room1()
{
    string roomDiscription = "You suddenly find yourself in a pristine and gleaming subway station, the sharp scent of industrial cleaner permeating the air.\nWhat's your next course of action?";
    string option1 = "To your [N]orth a train has pulled into the station. Its doors open, revealing a train attendant waiting to take riders tickets.";
    string option2 = "To your [E]ast you see a stairway leading down.";
    string option3 = "To your [W]est is nothing but trash can, and the cleanly scrubbed subway tile wall";
    string option4 = "To your [S]outh you can see a stairway leading up.";
    string roomEvent = "As you look around the station, you step in something sticky. A fresh train ticket has stuck to your shoe.";
    bool eventKey = false;
    bool roomChange = false;
    Console.Clear();
    SmallWelcomeScreen("".PadLeft(80, '-'));
    do
    {
        DisplayOptions(roomDiscription, option1, option2, option3, option4);
        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.N:
            {
                Console.WriteLine("As you approach the attendent reaches out his hand, asking for your ticket.");
                if (eventKey)
                {
                    Console.WriteLine("You present your ticket, which is swiftly punched. The attendent grabs you by the wrist and pulls you into the passenger car. The doors snap behind you.");
                    break;

                } else
                {
                    Console.WriteLine("Ticket please! If you dont have a ticket, please make room for paying customers.");
                    break;
                }
            }

            case ConsoleKey.E:
            {
                if(Confirm("Do you exit the room using the stairs to the East? [Y/N]"))
                {
                    roomChange=true;
                    return 2;
                }
                break;
            }

            case ConsoleKey.W:
            {
                Console.WriteLine("You approach the trash can. Like the rest of the room, it has been scrubbed clean.");
                break;
            }

            case ConsoleKey.S:
            {
                if(Confirm("Do you take the stairs leading up and out of the station. [Y/N]"))
                {
                    roomChange=true;
                    return 4;
                }
                break;
            }

        }
    } while (!roomChange);
    return 0;
}
int Room2 () 
{
    string roomDiscription = "You cautiously open the door and step into the room, greeted by the sight of a meticulously arranged yet slightly dusty classroom.\nWhat's your next move?";
    string option1 = "To the [N]orth you see a wall of blackboards.";
    string option2 = "To the [E]ast you see a sturdy wooden door leading out of the room.";
    string option3 = "To the [W]est a door with a staircase leading leading up behind it.";
    string option4 = "To the [S]outh there is a circular hole in the wall.";
    string roomEvent = "You can see a stick of chalk sitting on the metal edge of the blackboard.";
    bool eventKey = false;
    bool roomChange = false;
    string chalkString = " ";
    DisplayOptions(roomDiscription, option1, option2, option3, option4);
    do
    {
        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.N:
            {
                if (string.IsNullOrEmpty(chalkString))
                    Console.WriteLine("You approach the blackboard. If you had chalk, you could leave a message.");
                else
                    Console.WriteLine($"A message has been left on the blackboard, it reads {chalkString}");
                if (eventKey)
                {
                    Console.WriteLine("Its your lucky day, someone left a fresh stick of chalk just for you.");
                    if(Confirm("\nWould you like to leave a message ? [Y/N]"))
                    {
                        Console.WriteLine("What would you like to write?");
                        chalkString = Console.ReadLine();
                    }
                    break;

                } else
                {
                    Console.WriteLine("");
                    break;
                }
            }

            case ConsoleKey.E:
            {
                if (Confirm("The door connects to a long hallway. Enter the hallway? [Y/N]"))
                {
                    roomChange=true;
                    return 3;
                }
                break;
            }
            case ConsoleKey.W:
            {
                if(Confirm("You open the door to the staircase, sounds of what could be a train can be heard from the top of the stairs.\nClimb the stairs? [Y/N]"))
                {
                    roomChange=true;
                    return 1;
                }
                break;
                }

            case ConsoleKey.S:
            {
                if(Confirm("You approach the hole. It is pitch black and deep. There is no way to tell where this goes.\nCrawl into the hole? [Y/N]"))
                {
                    roomChange=true;
                    return 5;
                }
                break;
            }

        }
    } while (!roomChange);
    return 0;
}
int Room3 ()
{
    string roomDiscription = "You find yourself in an artist's studio filled with colorful canvases and splattered paint." +
        "\nSunlight streams in through large windows, illuminating the creative chaos." +
        "\nEasels, brushes, and half-finished paintings provide a glimpse into the artist's world.";
    string option1 = "To the [N]orth the beginings of a gallery can be seen.";
    string option2 = "To the [E]ast a wall of windows seperate you and the outside world.";
    string option3 = "To the [W]est a door covered in faded and chipped white paint can be seen.";
    string option4 = "To the [S]outh a closed metal industrial style door has been installed.";
    string roomEvent = "The room shakes and all the paintings fall from the wall.";
    bool eventKey = false;
    bool roomChange = false;
    DisplayOptions(roomDiscription, option1, option2, option3, option4);
    do
    {
        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.N:
            {
                if (eventKey)
                {
                    Console.WriteLine("The floor is cluttered with the paintings from the wall.");
                    break;

                } else
                {
                    Console.WriteLine("The sparse wall of paintings is infront of you. After a few minutes of contemplation you are sure about one thing. Whoever painted these has a very specific taste.");
                    break;
                }
            }

            case ConsoleKey.E:
            {
                Console.WriteLine("The view of the city below is spectacular. Despite their taste in art, the person who owns this studio is doing very well for themselfs.");
                break;
            }

            case ConsoleKey.W:
            {
                if(Confirm("A door connecting to a long hallway, enter the hallway? [Y/N]"))
                {
                    roomChange=true;
                    return 2;
                }

                break;
            }

            case ConsoleKey.S:
            {
                if (Confirm("A heavy metal door blocks you way. Undo the locks and slide the door open? [Y/N]"))
                {
                    roomChange=true;
                    return 6;
                }
                break;
            }
        }
    } while (!roomChange);
    return 0;
}
int Room4 ()
{
    string roomDiscription = "In a high-tech observatory, state-of-the-art telescopes point toward the cosmos. Star charts and astronomical instruments line the walls. " +
        "Through a glass dome, you can see the vast night sky and the twinkling stars that seem within reach.";
    string option1 = "To the [N]orth, the smell of anticeptic can be caught from a stairway leading down.";
    string option2 = "To the [E]ast, you find an office door.";
    string option3 = "To the [W]est, electronic controls and star charts line almost every inch of this wall. ";
    string option4 = "To the [S]outh, neon lights pour in from under a closed door. ";
    string roomEvent = "A mechanical cacophony erupts from the telescope in the center of the room. ";
    bool eventKey = false;
    bool roomChange = false;
    DisplayOptions(roomDiscription, option1, option2, option3, option4);
    do
    {
        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.N:
            {
                if (Confirm("Stairs leading down into a white tiled area. Decend the staircase? [Y/N]"))
                {
                    return 1;
                }
                break;
            }

            case ConsoleKey.E:
            {
                if(Confirm("You approach the office door and jiggle the handle. It's not locked, enter the office? [Y/N]"))
                {
                    return 5;
                }
                break;
            }

            case ConsoleKey.W:
            {
                if (eventKey)
                {
                    Console.WriteLine("As you approach digital displays fire up and a dot matrix printer pump out data in an unknown language.");
                    break;
                }
                else
                {
                    Console.WriteLine("You take a closer look at the wall of star charts. None of them seem to reference any formations you are familiar with.");
                    break;
                }
            }

            case ConsoleKey.S:
            {
                if(Confirm("Neon blue and pink lights are streaming in from under the door. Exit the room through this door? [Y/N]"))
                {
                    return 7;
                }
                break;
            }

        }
    } while (!roomChange);
    return 0;
}
int Room5 ()
{
    string roomDiscription = "You step into a classic western saloon, complete with swinging doors and a polished wooden bar. " +
        "The room is dimly lit, and the air is thick with the aroma of aged whiskey. Empty chairs surround poker tables, and the sounds of a player piano echo in the background.";
    string option1 = "To the [N]orth, an odd circular hole in the wall is found.";
    string option2 = "To the [E]ast,behind the bar, a red velvet drape covers a doorway.";
    string option3 = "To the [W]est, swinging doors are installed over an out of place office door.";
    string option4 = "To the [S]outh, you see doors to what you imagine to be the cellar.";
    string roomEvent = "As you explore the room, the player piano abrubtly stops. The hair on the back of your neck stands up. Something or someone is watching you.";
    bool eventKey = false;
    bool roomChange = false;
    DisplayOptions(roomDiscription, option1, option2, option3, option4);
    do
    {
        if(eventKey)
        {
            Console.WriteLine(roomEvent);
        }
        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.N:
            {
                if(Confirm("Climb through the hole? [Y/N]"))
                {
                    return 2;
                }
                break;
            }

            case ConsoleKey.E:
            {
                if(Confirm("You excuse yourself behind the bar. A plaque by door reads 'Quiet Please'. Pass through the drapes? [Y/N]"))
                {
                    return 6;
                }
                break;
            }

            case ConsoleKey.W:
            {
                if (Confirm("Pass through the swinging doors, and exit through the office door? [Y/N]"))
                {
                    return 4;
                }
                break;
            }

            case ConsoleKey.S:
            {
                if (Confirm("Swing open the cellar doors and decend? [Y/N]"))
                {
                    return 8;
                }
                break;
            }
            

        }
    } while (!roomChange);
    return 0;
}
int Room6 ()
{
    string roomDiscription = "You enter a library filled with ancient tomes and dusty scrolls. Tall bookshelves tower overhead, their contents bearing knowledge from centuries past and places unknown. " +
        "\nMysterious symbols adorn the covers, and the air is heavy with the scent of aged paper. A sense of history and secrets permeates the room.";
    string option1 = "To the [N]orth, a large metal sliding door latched closed.  ";
    string option2 = "To the [E]ast, a lecturn, and a shallow shelf packed with dusty tomes.   ";
    string option3 = "To the [W]est, velvet drapes cover an open passsage. ";
    string option4 = "To the [S]outh, an ornate door covered with polished brass filigree.";
    string roomEvent = "As you approach the shelving, books begin to fly off the shelf, ruining whatever categorization had been performed.";
    bool eventKey = false;
    bool roomChange = false;
    DisplayOptions(roomDiscription, option1, option2, option3, option4);
    do
    {
        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.N:
            {
              if(Confirm("You place your hands on the cold metal door. Slide it open and exit the room? [Y/N]"))
                {
                    return 3;
                }
                break;
            }

            case ConsoleKey.E:
            {
                if(eventKey)
                {
                    Console.WriteLine(roomEvent);
                    break;
                } else
                {
                    Console.WriteLine("Shelves line the wall, as you take a closer look you notice that whatever system is used to organize these books, it is completely foreign to you.");
                    break;
                }
            }

            case ConsoleKey.W:
            {
                if(Confirm("Pass through the drapes? [Y/N]"))
                {
                    return 5;
                }
                break;
            }

            case ConsoleKey.S:
            {
                if(Confirm("Approach the ornate door and leave? [Y/N]"))
                    {
                    return 9;
                    }
                break;
            }

        }
    } while (!roomChange);
    return 0;
}
int Room7 ()
{
    string roomDiscription = "You enter a narrow, neon-lit alleyway in a futuristic cyberpunk city. " +
        "\nHolographic billboards illuminate the surroundings, casting a vibrant glow on the grimy walls. Hovering drones whir above, and the air is filled with the faint hum of technology.";
    string option1 = "To the [N]orth, a door with a plaque that reads 'Observatory'.";
    string option2 = "To the [E]ast, an open set of sidewalk cellar doors.";
    string option3 = "To the [W]est, a digital bill board flickers to life.";
    string option4 = "To the [S]outh, wind blows through an empty public transit station. ";
    string roomEvent = "An oddly familiar train barrels through the transit station.";
    bool eventKey = false;
    bool roomChange = false;
    DisplayOptions(roomDiscription, option1, option2, option3, option4);
    do
    {
        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.N:
            {
               if(Confirm("Do you approach the observatory door and enter?[Y/N]"))
                {
                    return 4;
                }
                break;
            }

            case ConsoleKey.E:
            {
                if(Confirm("Decend into the street side cellar?[Y/N]"))
                {
                    return 8;
                }
                break;
            }

            case ConsoleKey.W:
            {
                Console.WriteLine("The billboard flashes the latest and greatest products, all while a built in camera gathers your reactions for future ad campaigns.");
                break;
            }

            case ConsoleKey.S:
            {
                Console.WriteLine("Graffiti covers most of the stations walls, while a screen flashes the expected arrival time of the next train.");
                break;
            }

        }
    } while (!roomChange);
    return 0;
}
int Room8 ()
{
    string roomDiscription = "Descending into an underground bunker, you discover a hidden world of espionage. " +
        "Dimly lit rooms contain vintage radio equipment, maps with cryptic markings, and rows of surveillance monitors. The air is tense with the weight of classified secrets.";
    string option1 = "To the [N]orth, the faint sounds of a piano can be heard from up a narrow set of stairs.";
    string option2 = "To the [E]ast, a dark and cobwebbed filled tunnel welcomes you.";
    string option3 = "To the [W]est, a technicolor stream of light poors down a metal staircase.";
    string option4 = "To the [S]outh, a wall of CRT monitors, reel-to-reel recorders and a cluttered table.";
    string roomEvent = "The monitors along the South wall being to count down. 3....2....1....0. Whatever it was counting down to must not have been important.";
    bool eventKey = false;
    bool roomChange = false;
    DisplayOptions(roomDiscription, option1, option2, option3, option4);
    do
    {
        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.N:
            {
               if (Confirm("Do you ascend the narrow staircase? [Y/N]"))
                {
                    {
                        return 5;
                    }
                }
                break;
            }

            case ConsoleKey.E:
            {
              if(Confirm("Travel into the dark tunnel?[Y/N]"))
                    {
                    return 9;
                    }
                break;
            }

            case ConsoleKey.W:
            {
                if(Confirm("Shield your eyes as you head into the bright staircase?"))
                {
                    return 7;
                }
                break;
            }

            case ConsoleKey.S:
            {
                Console.WriteLine("The monitors seem to depict odd angles of rooms you have passed through.");
                break;
            }
        }
    } while (!roomChange);
    return 0;
}
int Room9 ()
{
    string roomDiscription = "In a quaint clockmaker's workshop, antique timepieces line the shelves. " +
        "The room is filled with the rhythmic ticking and chiming of various clocks. Gears and cogs are meticulously arranged on workbenches, and a grandfather clock stands tall in the corner.";
    string option1 = "To the [N]orth, a sturdy wooden door sits closed.";
    string option2 = "To the [E]ast, display cases line a store front window.";
    string option3 = "To the [W]est, a beaded doorway, with a sign reading 'Employee's Only'.";
    string option4 = "To the [S]outh, an assortment of delicate tools and a complicated mechanisms rest on a thick oak table.";
    string roomEvent = "Suddenly, all the clocks chime at once, catching you off guard as you hastily cover your ears to shield yourself from the unexpected cacophonous sound.";
    bool eventKey = false;
    bool roomChange = false;
    DisplayOptions(roomDiscription, option1, option2, option3, option4);
    do
    {
        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.N:
            {
                if(Confirm("Exit the shop through the wooden door? [Y/N]"))
                {
                    return 6;
                }
                break;
            }

            case ConsoleKey.E:
            {
                Console.WriteLine("You take a second to appreciate the fine craftsmanship of the displayed time pieces.");
                break;
            }

            case ConsoleKey.W:
            {
                if(Confirm("Ignore the 'Employee's Only' sign and walk pass the bead door?[Y/N"))
                {
                    return 8;
                }
                break;
            }

            case ConsoleKey.S:
            {
                Console.WriteLine("Approach the work bench and manage to resist the urge to tinker with some of these on-going projects.");
                break;
            }

        }
    } while (!roomChange);
    return 0;
}
void DisplayOptions(string roomDescription,string option1,  string option2, string option3, string option4)
{
    Console.WriteLine("".PadLeft(40, '-'));
    Console.WriteLine(roomDescription);
    Console.WriteLine("".PadLeft(40, '-'));
    Console.WriteLine(option1 + "\n" + option2 + "\n" +option3+ "\n" +option4);
    Console.WriteLine("".PadLeft(40, '-'));

}





//-----Main-----
string dottedLine = new string('-', 85);
int playerRoom = 0;
bool gameOver = false;




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
SmallWelcomeScreen(dottedLine);
playerRoom=1;
do
{
    switch(playerRoom)
    {
        case 1: playerRoom = Room1(); break;
        case 2: playerRoom = Room2(); break;
        case 3: playerRoom = Room3(); break;
        case 4: playerRoom = Room4(); break;
        case 5: playerRoom = Room5(); break;
        case 6: playerRoom = Room6(); break;
        case 7: playerRoom = Room7(); break;
        case 8: playerRoom = Room8(); break;
        case 9: playerRoom = Room9(); break;
        case 0: gameOver=true; break;
    }
} while (!gameOver);


//TODO: Split displayoptions function into 2. 1 for room descript, 1 for the options.

//TODO: Find a way to clean up the console output. Currently unreadable.

//TODO: Random event implementation
//int GeneratePercentage ()
//{
//    return Random.Shared.Next(1, 101);
//}

//TODO: Add room placement message

//TODO: Add exit option to each room

//TODO:Rethink the player tracking.

//TODO: Double check code style from project instructions.
//do NOT recursively call the game loop, double check for spelling errors

//Game loop only closes when the player prompts it to end, validate user input

//story 4 - Quit command, with quit confirmation

//story 5 - Design the game world. Plan out the 3x3 grid. Only rooms adjacent to each other can be reached.

//story 6 - Moving between rooms, display current player room and confirm player positions in new rooms, player location maybe tracked by a 2d array?

//story 7 - Room descriptions, what exits are available, suggesting seperate function for each room.

//story 8 - random encounters %5 chance, function given in instructions

