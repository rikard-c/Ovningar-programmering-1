namespace Övningar_kapitel_11___Del_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hello("Tanjiro");
            Console.WriteLine(Concatenate("Tanjiro is a ", "demon slayer."));
            Console.WriteLine(Add(4, 5, 6));
            Console.WriteLine($"50% av 100 kr är {CalculatePercetageAmount(100, 50)} kr");
            Console.WriteLine($"50% av 75,67 kr är {CalculatePercetageAmount(75.67, 50)} kr");
            Console.WriteLine($"25% av 11000 kr är {CalculatePercetageAmount(11000, 25)} kr");
            Console.WriteLine(IsMean(5, 5, 5, 5));
            Console.WriteLine(IsMean(5, 4, 5, 5));
            int a = 1;
            int b = 2;
            Swap(ref a, ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);

            int rollCount = 0;
            int diceSum = 0;

            for (int i = 0; i < 10; i++)
            {
                DiceThrow(ref rollCount, ref diceSum);
            }

            Console.WriteLine("Antal kast: " + rollCount);
            Console.WriteLine("Total summa av tärningskasten: " + diceSum);
        }

        static void Hello(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }

        static string Concatenate(string a, string b)
        {
            return a + b;
        }

        static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        static double CalculatePercetageAmount(double amount, int percentage)
        {
            return amount * ((double)percentage / 100);
        }

        static bool IsMean(double mean, double a, double b, double c)
        {
            return ((a + b + c) / 3) == mean;
        }

        static bool IsRightAngeledTriangle(double a, double b, double c)
        {
            if (a * a + b * b == c * c)
                return true;
            else
                return false;
        }

        static bool IsNumeric(string text)
        {
            if (string.IsNullOrEmpty(text))
                return false;

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        static bool IsPalindrome(string text)
        {
            string textWithoutSpaces = string.Empty;

            // Remove all special characters
            for (int i = 0; i < text.Length; i++)
            {
                char c = char.ToLower(text[i]);

                if ((c >= 'a' && c <= 'z') || c == 'å' || c == 'ä' || c == 'ö')
                {
                    textWithoutSpaces += c;
                }
            }

            for (int i = 0; i < textWithoutSpaces.Length / 2; i++)
            {
                if (textWithoutSpaces[i] != textWithoutSpaces[textWithoutSpaces.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static void DiceThrow(ref int rollCount, ref int diceSum)
        {
            rollCount++;
            Random rnd = new Random();
            diceSum += rnd.Next(1, 7);
        }





    }
}
