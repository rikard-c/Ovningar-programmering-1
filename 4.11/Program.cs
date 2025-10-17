namespace _4._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            while (true) 
            { 
                Console.WriteLine("Ange bakgrundsfärg");
                Console.WriteLine("1 för röd, 2 för blå, 3 för grön, 4 för gul");
                var key = Console.ReadKey(true);
                
                switch (key.KeyChar)
                {
                    case '1':
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        break;
                    case '2':
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Clear();
                        break;
                    case '3':
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Clear();
                        break;
                    case '4':
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Clear();
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
