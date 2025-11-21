using System.Xml.Schema;

namespace Traffic_light
{
    internal class Program
    {
        enum TrafficLight
        {
            Red,
            Yellow,
            Green        
        }

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

            TrafficLight current = TrafficLight.Red;
            // Variabel för att veta när det varit gult för andra gången
            int restart = 0;
            
            while (true) 
            {
                if (restart == 2) 
                { 
                    current = TrafficLight.Red;
                    restart = 0;    
                }


                switch (current) 
                { 
                    case TrafficLight.Red:
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
                    System.Threading.Thread.Sleep(1000);
                    current = TrafficLight.Yellow;
                    break;

                    case TrafficLight.Yellow:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(10, 6);
                    Console.Write(" ");
                    System.Threading.Thread.Sleep(1000);
                    current = TrafficLight.Green;
                    restart++;
                    break;

                    case TrafficLight.Green:
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(10, 4);
                    Console.Write(" ");
                    Console.SetCursorPosition(10, 6);
                    Console.Write(" ");
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(10, 8);
                    Console.Write(" ");
                    System.Threading.Thread.Sleep(1000);
                    current = TrafficLight.Yellow;
                    break;
                }
            }
        }
    }
}
