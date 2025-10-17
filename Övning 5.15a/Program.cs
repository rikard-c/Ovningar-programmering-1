namespace Övning_5._15a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int rectangleWidht = 0;
            int rectangleHeight = 0;
        
            while (true)
            {
                Console.Write("Ange rektangels bredd: ");
                int.TryParse(Console.ReadLine(), out rectangleWidht);
                Console.Write("Ange rektangels höjd: ");
                int.TryParse(Console.ReadLine(), out rectangleHeight);
                if (rectangleWidht > 0 && rectangleWidht < 120 && rectangleHeight > 0 && rectangleHeight < 30)
                    break;
                else
                    Console.WriteLine("Ogiltiga värden!");
            }
        
            Console.Clear();
        
            Console.BackgroundColor = ConsoleColor.Green;
        
            for (int i = 0; i <= rectangleWidht; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(" ");
                Thread.Sleep(10);
                x++;
            }
        
            for (int i = 0; i < rectangleHeight; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(" ");
                Thread.Sleep(10);
                y++;
            }
        
            for (int i = 0; i <= rectangleWidht; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(" ");
                Thread.Sleep(10);
                x--;
            }
        
            for (int i = 0; i < rectangleHeight; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(" ");
                Thread.Sleep(10);
                y--;
            }
        
            Console.SetCursorPosition(0, rectangleHeight + 1);
        
            Console.BackgroundColor = ConsoleColor.Black;
        
        }
    }
}
