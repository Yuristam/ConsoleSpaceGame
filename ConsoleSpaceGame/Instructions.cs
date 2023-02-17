namespace ConsoleSpaceGame
{
    internal class Instructions
    {
        // TODO сделать очки слева, а инструкцию с права, жизнь с права.
        // TODO сделать массив камней, [] или вот так, и типа они падают с неба (с вверху консоли)
        internal static void ShowInstructions()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("GAME INSTRUCTIONS:\r\n\r\n" +
                "Press left arrow to move\r\nyour ship left (<),\r\n" +
                "right arrow to move\r\nyour ship right (>).\r\n" +
                "avoid rocks '0', barriers '[]'\r\nand of course enemies.\r\n");
            
            //======================================================================
            
            Console.ForegroundColor= ConsoleColor.DarkYellow;
            for (int i = 0; i < 29; i++)
            {
                Console.Write("=");
            }

            //======================================================================

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\r\n\r\nENEMIES:\r\n\r\n" +
                "-|!|-\r\n-[!]-\r\n-{\\/}-");

            Console.ResetColor();
        }
        internal static void ShowLife() 
        {
            Console.SetCursorPosition(81, 0);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("  Life Bar: [");

            
            for (int i = 0; i < 9; i++)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write(' ');
            }
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(']');
            Console.ResetColor();
        }
        internal static void ShowScore() 
        {
            Console.SetCursorPosition(81, 5);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("  Score: ");
        }
    }
}
