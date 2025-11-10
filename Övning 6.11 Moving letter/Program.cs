namespace Övning_6._11_Moving_letter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = Console.WindowWidth;
            int height = Console.WindowHeight;
            int x = width / 2;
            int y = height / 2;
            ConsoleKeyInfo userInput;

            Console.SetCursorPosition(x, y);
            Console.Write("o");
            Console.CursorVisible = false;

            while (true)
            {
                Console.SetCursorPosition(0,0);
                Console.WriteLine("Ange riktning (u)pp, (n)er, (v)änster, (h)öger, (a)vsluta: ");
                userInput = Console.ReadKey(intercept: true);
                char direction = userInput.KeyChar;

                if (direction == 'a')
                    break;

                for (int i = 0; i < 16; i++)
                {
                    // Delete o
                    Console.SetCursorPosition(x, y);
                    Console.Write(" ");

                    // Change coordinate one step in the selected direction
                    switch (direction)
                    {
                        case 'u':
                            if (y > 0)
                                y--;
                            break;

                        case 'n':
                            if (y < height - 1)
                                y++;
                            break;

                        case 'v':
                            if (x > 0)
                                x--;
                            break;

                        case 'h':
                            if (x < width - 1)
                                x++;
                            break;

                        default:
                            break;
                    }

                    // Draw o at new coordinate
                    Console.SetCursorPosition(x, y);
                    Console.Write("o");

                    // Pause
                    Thread.Sleep(50);
                }
            }
        }
    }
}
