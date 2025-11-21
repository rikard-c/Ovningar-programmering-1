using System.Resources;

namespace Övning_8._6_Traffic_light_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.CursorVisible = false;
            Console.Clear();

            // Draw traffic light
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("         ╔═╗");
            Console.WriteLine("         ║ ║");
            Console.WriteLine("         ╠═╣");
            Console.WriteLine("         ║ ║");
            Console.WriteLine("         ╠═╣");
            Console.WriteLine("         ║ ║");
            Console.WriteLine("         ╚╦╝");
            Console.WriteLine("          ║");
            Console.WriteLine("          ║");
            Console.WriteLine("          ║");
            Console.WriteLine("          ║");
            Console.WriteLine("          ║");
            Console.WriteLine("          ║");
            Console.WriteLine("          ║");
            Console.WriteLine("          ║");
            Console.WriteLine("          ║");
            Console.WriteLine("          ║");

            int state = 0;
            // lookup-tabell för att ha fyra states
            int[] netxtState = { 1, 2, 3, 0 };

            while (true)
            {
                switch (state)
                {
                    // Red
                    case 0:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(10, 4);
                        Console.Write(" ");
                        Console.SetCursorPosition(10, 6);
                        Console.Write(" ");
                        Console.SetCursorPosition(10, 8);
                        Console.Write(" ");
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(10, 4);
                        Console.Write(" ");
                        System.Threading.Thread.Sleep(2000);
                        //state = 1;
                        break;

                    // Yellow
                    case 1:
                    case 3:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(10, 6);
                        Console.Write(" ");
                        System.Threading.Thread.Sleep(2000);
                        //state = 2;
                        break;

                    // Green
                    case 2:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(10, 4);
                        Console.Write(" ");
                        Console.SetCursorPosition(10, 6);
                        Console.Write(" ");
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(10, 8);
                        Console.Write(" ");
                        System.Threading.Thread.Sleep(2000);
                        //state = 3;
                        break;
                }
                // Till nästa state
                state = netxtState[state];
            }
        }
    }
}
