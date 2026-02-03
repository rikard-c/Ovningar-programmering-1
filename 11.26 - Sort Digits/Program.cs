namespace _11._26___Sort_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("SORTERA SIFFROR\n-----------------------------");
                var input = ReadDigitString("Ange en sträng av godtyckliga siffror: ");
                Console.WriteLine($"Siffrorna sorterade: {Sort(input)}");
                Console.WriteLine($"Siffrorna unikt sorterade: {Unique(input)}");
                Console.WriteLine($"Medianvärdet är {Median(input)}");
                Console.ReadKey();
            }
        }

        /* Write a message to the console and returns 
		 * a string consisting of only digits.
		 */
        private static string ReadDigitString(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (input == null || input.Length == 0)
                {
                    Console.WriteLine("Felaktig inmatning! Du måste skriva minst en siffra.");
                    continue;
                }

                bool onlyDigits = true;

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] < '0' || input[i] > '9')
                    {
                        onlyDigits = false;
                        break;
                    }
                }

                if (onlyDigits)
                    return input;

                Console.WriteLine("Felaktig inmatning! Ange endast siffror.");
            }
        }

        private static string Sort(string digits)
        {
            string sortedDigits = string.Empty;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < digits.Length; j++)
                {
                    if (i == digits[j] - '0')
                        sortedDigits += digits[j];
                }
            }
            return sortedDigits;
        }

        private static string Unique(string digits)
        {
            string sortedString = Sort(digits);
            var uniqueString = string.Empty;

            for (int i = 0; i < sortedString.Length - 1; i++)
            {
                if (sortedString[i] != sortedString[i + 1])
                    uniqueString += sortedString[i];
            }

            uniqueString += sortedString[sortedString.Length - 1];

            return uniqueString;
        }

        private static int Median(string digits)
        {
            var sortedDigits = Sort(digits);
            var length = sortedDigits.Length;
            if (length % 2 == 1)
                return (sortedDigits[length / 2]);
            else
            {
                if (length == 2)
                {
                    return (sortedDigits[0] - '0' + sortedDigits[1] - '0') / 2;
                }
                var half = sortedDigits.Length / 2;
                return (sortedDigits[half] - '0' + sortedDigits[half + 1] - '0') / 2;
            }

        }
    }
}
