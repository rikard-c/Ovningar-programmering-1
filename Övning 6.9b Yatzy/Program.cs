namespace Övning_6._9b_Yatzy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] dices =
            {
                {"╔═══════╗", "║       ║", "║   o   ║", "║       ║", "╚═══════╝" },
                {"╔═══════╗", "║ o     ║", "║       ║", "║     o ║", "╚═══════╝" },
                {"╔═══════╗", "║ o     ║", "║   o   ║", "║     o ║", "╚═══════╝" },
                {"╔═══════╗", "║ o   o ║", "║       ║", "║ o   o ║", "╚═══════╝" },
                {"╔═══════╗", "║ o   o ║", "║   o   ║", "║ o   o ║", "╚═══════╝" },
                {"╔═══════╗", "║ o   o ║", "║ o   o ║", "║ o   o ║", "╚═══════╝" },
            };

            int x = 5;
            int round = 0;
            Random random = new Random();
            Console.CursorVisible = false;

            while (true) 
            { 
                for (int i = 0; i < 5; i++)
                {
                    int diceThrow = random.Next(0,6);
                    for (int j = 0; j < 5; j++)
                    {
                        Console.SetCursorPosition(x, j+2);
                        Console.WriteLine(dices[diceThrow,j]);
                    }

                    x += 10; //Flyttar 10 steg åt höger
                }
                round++;
                Console.ReadKey();
                Console.Clear();
                x = 5;
            }
        }
    }
}
