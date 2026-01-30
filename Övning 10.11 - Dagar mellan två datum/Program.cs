namespace Övning_10._11___Dagar_mellan_två_datum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Beräkning av antal dagar mellan två datum\n");
            while (true)
            {
                int date1 = GetUserInput("Ange datum 1 på formatet yyyymmdd: ");
            }
            int date2 = GetUserInput("Ange datum 2 på formatet yyyymmdd: ");
        }

        static int GetUserInput(string message)
        {
            int number = 0;
            string input = string.Empty;
            while (true)
            {
                Console.Write(message);
                input = Console.ReadLine();
                try
                {
                    if (input.Length == 8)
                    {
                        for (int i = 0; i < input.Length; i++)
                        {
                            if (input[i] < '0' || input[i] > '9')
                                throw new Exception();
                        }
                        int year = int.Parse(input.Substring(0, 4));
                        int month = int.Parse(input.Substring(4, 2));
                        int day = int.Parse(input.Substring(6, 2));
                        if (month < 1 || month > 12 || day < 1 || day > DaysInMonth(year, month))
                            throw new Exception();
                    }
                    else
                    {
                        throw new Exception();
                    }
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Ogiltigt datum. Försök igen.");
                }
            }
            return number;
        }

        static int DaysInMonth(int year, int monthInput)
        {
            if (monthInput == 2 && IsLeapYear(year))
                return 29;
            int[] daysInMonth = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            return daysInMonth[monthInput - 1];
        }

        static bool IsLeapYear(int year)
        {
            if (year % 400 == 0)
                return true;
            if (year % 100 == 0)
                return false;
            if (year % 4 == 0)
                return true;
            return false;
        }
    }
}
