namespace Övning_8._7___Pacman_ghost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 2;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Clear();
            Console.CursorVisible = false;

            //Draw path
            Console.WriteLine();
            Console.WriteLine(" ╔═════════════════════════════════╗");
            Console.WriteLine(" ║                                 ║");
            Console.WriteLine(" ║                                 ║");
            Console.WriteLine(" ║                                 ║");
            Console.WriteLine(" ║     ╔═════════════════════╗     ║");
            Console.WriteLine(" ║     ║                     ║     ║");
            Console.WriteLine(" ║     ║                     ║     ║");
            Console.WriteLine(" ║     ║                     ║     ║");
            Console.WriteLine(" ║     ║                     ║     ║");
            Console.WriteLine(" ║     ║                     ║     ║");
            Console.WriteLine(" ║     ║                     ║     ║");
            Console.WriteLine(" ║     ║                     ║     ╚════════════════════════════╗");
            Console.WriteLine(" ║     ║                     ║                                  ║");
            Console.WriteLine(" ║     ║                     ║                                  ║");
            Console.WriteLine(" ║     ║                     ║                                  ║");
            Console.WriteLine(" ║     ║                     ╚════════════════════════════╗     ║");
            Console.WriteLine(" ║     ║                                                  ║     ║");
            Console.WriteLine(" ║     ║                                                  ║     ║");
            Console.WriteLine(" ║     ║                                                  ║     ║");
            Console.WriteLine(" ║     ║                                                  ║     ║");
            Console.WriteLine(" ║     ║                                                  ║     ║");
            Console.WriteLine(" ║     ║                                                  ║     ║");
            Console.WriteLine(" ║     ╚══════════════════════════════════════════════════╝     ║");
            Console.WriteLine(" ║                                                              ║");
            Console.WriteLine(" ║                                                              ║");
            Console.WriteLine(" ║                                                              ║");
            Console.WriteLine(" ╚══════════════════════════════════════════════════════════════╝");

            while (true)
            {
                // Draw ghost
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(x, y);
                Console.WriteLine(" ▄▄▄");
                Console.SetCursorPosition(x, y + 1);
                Console.Write("█");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("o");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("█");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("o");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("█");
                Console.SetCursorPosition(x, y + 2);
                Console.WriteLine("█▀█▀█");

                // Pause
                System.Threading.Thread.Sleep(80);

                // Delete ghost
                Console.SetCursorPosition(x, y);
                Console.WriteLine("     ");
                Console.SetCursorPosition(x, y + 1);
                Console.WriteLine("     ");
                Console.SetCursorPosition(x, y + 2);
                Console.WriteLine("     ");

                // Move
                x++;

            }
        }
    }
}
