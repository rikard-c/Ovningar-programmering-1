namespace Övning_5._20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, color, letterNumber, noOfLetters = 0;
            string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            bool success = false;
            string randomColors = string.Empty;

            Random rnd = new Random();

            while (!success)
            {
                Console.Write("Hur många bokstäver vill du slumpa fram: ");
                success = int.TryParse(Console.ReadLine(), out noOfLetters);
                if (!success)
                    Console.WriteLine("Ogiltigt val!");
            }

            success = false;

            while(!success)
            {
                Console.Write("Vill du ha slumpade färger (j, n): ");
                string answer = Console.ReadLine();
                if (answer == "j" || answer == "n") 
                { 
                    success = true;
                    randomColors = answer;
                }
                else
                    Console.WriteLine("Ogiltigt val!");
            }

            Console.Clear();

            for (int i = 0; i < noOfLetters; i++)
            {
                x = rnd.Next(1, 120);
                y = rnd.Next(1, 29);
                color = rnd.Next(1, 5);
                Console.SetCursorPosition(x, y);
                if (randomColors == "j")
                {
                    switch (color)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                    }
                }
                letterNumber = rnd.Next(0, alphabet.Length);
                Console.Write(alphabet[letterNumber]);
            }
            Console.ReadKey();
        }
    }
}
