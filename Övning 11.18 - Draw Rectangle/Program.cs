namespace Övning_11._18___Draw_Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Ange position och mått för rektangeln.");

                /*
                 * Read rectangle position and size from user
                 * 
                 */
                int x = GetUserInteger("Ange x: ");
                int y = GetUserInteger("Ange y: ");
                int width = GetUserInteger("Ange bredd: ");
                int height = GetUserInteger("Ange höjd: ");

                /*
                 * Present values and draw rectangle (if possible)
                 * 
                 */
                Console.Clear();
                Console.WriteLine("x: " + x + " y: " + y + " bredd: " + width + " höjd: " + height);
                bool validValues = DrawRectangle(x, y, width, height);

                if (!validValues)
                    Console.WriteLine("Rektangeln kunde inte ritas.");


                Console.ReadKey();
                Console.Clear();
            }
        }

        static int GetUserInteger(string message)
        {
            int result = 0;
            while (true)
            {
                try
                {
                    Console.Write(message);
                    string input = Console.ReadLine();
                    result = int.Parse(input);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Ogiltigt värde. Ange ett heltal. Försök igen.");
                }
            }
            return result;
        }

        /*
         * DrawRectangle draws a rectangle at position (x, y)
         * with a given width and height if the following 
         * requirements are fullfilled, otherwise not:
         * 
         *   x ≥ 0
         *   y ≥ 0
         *   width ≥ 2
         *   height ≥ 2
         *   x + width ≤ ConsoleWindowWidth
         *   y + height ≤ ConsoleWindowHeight
         *
         * The method returns true if it was possible to draw
         * a rectangle, false otherwise.
         *
         */
        static bool DrawRectangle(int x, int y, int width, int height)
        {
            // Rita rektangeln med hjälp av följande tecken:   ╔ ═ ╗ ║ ╚ ╝
            if (x <= 0 ||
                y <= 0 ||
                width <= 2 ||
                height <= 2 ||
                (x + width) >= Console.WindowWidth ||
                (y + height) >= Console.WindowHeight)
                return false;

            // Draw the top and bottom line of the rectangle
            for (int i = 1; i < width - 1; i++) 
            { 
                Console.SetCursorPosition(x + i, y);
                Console.Write("═");
                Console.SetCursorPosition(x + i, y + height - 1);
                Console.Write("═");
            }

            // Draw the side lines of the rectangle
            for (int i = 1; i < height - 1; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write("║");
                Console.SetCursorPosition(x + width - 1, y + i);
                Console.Write("║");
            }

            //Draw the corners
            Console.SetCursorPosition(x, y);
            Console.Write("╔");
            Console.SetCursorPosition(x + width - 1, y);
            Console.Write("╗");




            return true;
        }
    }
}
