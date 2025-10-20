namespace Övning_6._9_Yatzy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int xPos = 0;
            Random random = new Random();
            Console.CursorVisible = false;

            while (true) 
            {
                for (int i = 0; i < 5; i++)
                {
                    int diceThrow = random.Next(1, 7);

                    switch (diceThrow)
                    {
                        case 1:
                            {
                                Console.SetCursorPosition(xPos, 0);
                                Console.WriteLine("╔═══════╗");
                                Console.SetCursorPosition(xPos, 1);
                                Console.WriteLine("║       ║");
                                Console.SetCursorPosition(xPos, 2);
                                Console.WriteLine("║   o   ║");
                                Console.SetCursorPosition(xPos, 3);
                                Console.WriteLine("║       ║");
                                Console.SetCursorPosition(xPos, 4);
                                Console.WriteLine("╚═══════╝");
                                xPos += 10;
                                break;
                            }
                        case 2:
                            {
                                Console.SetCursorPosition(xPos, 0);
                                Console.WriteLine("╔═══════╗");
                                Console.SetCursorPosition(xPos, 1);
                                Console.WriteLine("║ o     ║");
                                Console.SetCursorPosition(xPos, 2);
                                Console.WriteLine("║       ║");
                                Console.SetCursorPosition(xPos, 3);
                                Console.WriteLine("║     o ║");
                                Console.SetCursorPosition(xPos, 4);
                                Console.WriteLine("╚═══════╝");
                                xPos += 10;
                                break;
                            }
                        case 3:
                            {
                                Console.SetCursorPosition(xPos, 0);
                                Console.WriteLine("╔═══════╗");
                                Console.SetCursorPosition(xPos, 1);
                                Console.WriteLine("║ o     ║");
                                Console.SetCursorPosition(xPos, 2);
                                Console.WriteLine("║   o   ║");
                                Console.SetCursorPosition(xPos, 3);
                                Console.WriteLine("║     o ║");
                                Console.SetCursorPosition(xPos, 4);
                                Console.WriteLine("╚═══════╝");
                                xPos += 10;
                                break;
                            }
                        case 4:
                            {
                                Console.SetCursorPosition(xPos, 0);
                                Console.WriteLine("╔═══════╗");
                                Console.SetCursorPosition(xPos, 1);
                                Console.WriteLine("║ o   o ║");
                                Console.SetCursorPosition(xPos, 2);
                                Console.WriteLine("║       ║");
                                Console.SetCursorPosition(xPos, 3);
                                Console.WriteLine("║ o   o ║");
                                Console.SetCursorPosition(xPos, 4);
                                Console.WriteLine("╚═══════╝");
                                xPos += 10;
                                break;
                            }
                        case 5:
                            {
                                Console.SetCursorPosition(xPos, 0);
                                Console.WriteLine("╔═══════╗");
                                Console.SetCursorPosition(xPos, 1);
                                Console.WriteLine("║ o   o ║");
                                Console.SetCursorPosition(xPos, 2);
                                Console.WriteLine("║   o   ║");
                                Console.SetCursorPosition(xPos, 3);
                                Console.WriteLine("║ o   o ║");
                                Console.SetCursorPosition(xPos, 4);
                                Console.WriteLine("╚═══════╝");
                                xPos += 10;
                                break;
                            }
                        case 6:
                            {
                                Console.SetCursorPosition(xPos, 0);
                                Console.WriteLine("╔═══════╗");
                                Console.SetCursorPosition(xPos, 1);
                                Console.WriteLine("║ o   o ║");
                                Console.SetCursorPosition(xPos, 2);
                                Console.WriteLine("║ o   o ║");
                                Console.SetCursorPosition(xPos, 3);
                                Console.WriteLine("║ o   o ║");
                                Console.SetCursorPosition(xPos, 4);
                                Console.WriteLine("╚═══════╝");
                                xPos += 10;
                                break;
                            }
                    }
                }
                    Console.ReadKey();
                xPos = 0;
                    Console.Clear();
            }
        }
    }
}
