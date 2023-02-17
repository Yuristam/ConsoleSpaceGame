using ConsoleSpaceGame;

// Player's ship positions (X => abscissa, Y => ordinate)
int userX = 50, userY = 27;

while (true)
{
    Instructions.ShowInstructions();
    Instructions.ShowLife();
    Instructions.ShowScore();

    //========================================================================

    // this is the borders of the map
    for (int i = 0; i < 30; i++)
    {
        Console.SetCursorPosition(30, i);
        Console.Write('|');
        Console.SetCursorPosition(80, i);
        Console.Write('|');
    }
    //========================================================================

    // player's positions (that will be in use)
    Console.SetCursorPosition(userX, userY);
    Console.Write("-[|]-{<^>}-[|]-");                   // player's ship

    ConsoleKeyInfo player = Console.ReadKey();
    switch (player.Key)
    {
        case ConsoleKey.LeftArrow:
            if (userX - 1 != 30)
            {
                userX--; // move left
            }
            break;
        case ConsoleKey.RightArrow:
            if (userX + 1 != 66)
            {
                userX++; // move right 
            }
            break;
    }
    Console.Clear();
}