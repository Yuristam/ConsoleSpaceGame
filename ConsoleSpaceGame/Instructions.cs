namespace ConsoleSpaceGame
{
    internal class Instructions
    {
        // TODO сделать массив камней, [] или вот так, и типа они падают с неба (с вверху консоли)
        // TODO сделать асинк в будущем
        internal static /*async*/ void ShowLoading()
        {
            Console.ForegroundColor= ConsoleColor.DarkYellow;

            string dots = "...";
            string loading = "LOADING";          //0                  //1
            string[] information = { " - checking system"," - booting system\r\n",
                "\r\nMemory Unit: Green\r\n", "Initializing Tactics Log\r\n", "Loading Geographic Data\r\n",
                "Vitals: Green\r\n", "Remaining MP: 100%\r\n", "Black Box Temperature: Normal\r\n",
                "Black Box Internal Pressure: Normal\r\n","Activating IFF\r\n", "Activating FCS\r\n","Activating OS\r\n",
                "Activating Graphics Card\r\n","Setting Up Graphics Card: Maximum\r\n","Initializing Pod Connection\r\n",
                "Launching DBU Setup\r\n","Activating Inertia Control System\r\n", "Activating Invironmental Sensors\r\n",
                "Equipment Authentication: Complete\r\n","Equipment Status: Green\r\n", "All Systems Green\r\n",
                "Combat Preparations Complete\r\n","Loading System Data\r\n","Creating Space Enviroment\r\n",
                "Cores Activated: 4\r\n","Threads Used: 8\r\n","Fuel: 100%\r\n","Launching Spacecraft\r\n"};

            loading.ToCharArray();
            dots.ToCharArray();

            for (int i = 0; i < loading.Length; i++)
            {
                Thread.Sleep(50);
                Console.Write(loading[i]);
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < dots.Length; j++)
                {
                    Thread.Sleep(150);
                    Console.Write(dots[j]);
                }
                Console.Clear();
                Console.Write(loading);
            }
            for (int i = 0; i < information.Length; i++)
            {
                Thread.Sleep(200);
                information[i].ToCharArray();
                for (int j = 0; j < information[i].Length; j++)
                {
                    Console.Write(information[i][j]);
                    Thread.Sleep(20);
                }
            }
            for (int i = 0; i < Console.BufferWidth; i++)
            {
                Thread.Sleep(20);
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write(' ');
            }
            Console.ResetColor();
            Console.Clear();
        }
        internal static void ShowInstructions()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("GAME INSTRUCTIONS:\r\n\r\n" +
                "Press left arrow to move\r\nyour ship left (<),\r\n" +
                "right arrow to move\r\nyour ship right (>).\r\n" +
                "avoid rocks '0', barriers '[]'\r\nand of course enemies.\r\n");

            //======================================================================

            Console.ForegroundColor = ConsoleColor.DarkYellow;
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
