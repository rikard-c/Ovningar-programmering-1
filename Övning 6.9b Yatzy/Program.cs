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
            List<int> diceThrows = new List<int>(); 
            Random random = new Random();
            Console.CursorVisible = false;
            bool allSame = false;
            string input = "j";

            while (input == "j")
            {
                allSame = false;
                round = 0;
                while (!allSame)
                {
                    Console.Clear();
                    diceThrows.Clear();
                    for (int i = 0; i < 5; i++)
                    {
                        int diceThrow = random.Next(0, 6);
                        diceThrows.Add(diceThrow);
                        for (int j = 0; j < 5; j++)
                        {
                            Console.SetCursorPosition(x, j + 2);
                            Console.WriteLine(dices[diceThrow, j]);
                        }

                        x += 10; //Flyttar 10 steg åt höger
                    }
                    allSame = diceThrows.All(x => x == diceThrows[0]);
                    round++;
                    //Console.ReadKey();
                    x = 5;
                }
                Console.WriteLine($"\n Du fick 5 st {diceThrows[0] + 1}:or efter {round} försök");
                Console.Write("\n Vill du försöka igen (j/n)?: ");
                input = Console.ReadLine();
            }
        }
    }
}
