namespace Övning_8._13___Pacman_ghost_moving
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

            Console.WriteLine();
            Console.WriteLine(" ╔═══════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine(" ║                                                                                                       ║");
            Console.WriteLine(" ║                                                                                                       ║");
            Console.WriteLine(" ║                                                                                                       ║");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(" ║     ╔═══════╗     ╔═══════╗     ╔═══════╗     ╔═══════╗     ╔═══════╗     ╔═══════╗     ╔═══════╗     ║");
                Console.WriteLine(" ║     ║       ║     ║       ║     ║       ║     ║       ║     ║       ║     ║       ║     ║       ║     ║");
                Console.WriteLine(" ║     ║       ║     ║       ║     ║       ║     ║       ║     ║       ║     ║       ║     ║       ║     ║");
                Console.WriteLine(" ║     ╚═══════╝     ╚═══════╝     ╚═══════╝     ╚═══════╝     ╚═══════╝     ╚═══════╝     ╚═══════╝     ║");
                Console.WriteLine(" ║                                                                                                       ║");
                Console.WriteLine(" ║                                                                                                       ║");
                Console.WriteLine(" ║                                                                                                       ║");
            }

            Console.WriteLine(" ╚═══════════════════════════════════════════════════════════════════════════════════════════════════════╝");

            while (true)
            {
                // Draw
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

                // Delete
                Console.SetCursorPosition(x, y);
                Console.WriteLine("     ");
                Console.SetCursorPosition(x, y + 1);
                Console.WriteLine("     ");
                Console.SetCursorPosition(x, y + 2);
                Console.WriteLine("     ");

                // Move

            }
        }
    }
}
