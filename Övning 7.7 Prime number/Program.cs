namespace Övning_7._7_Prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Välkommen till primtalskollen!\n----------------");
                Console.Write("Ange ett heltal: ");
                string input = Console.ReadLine();
                bool success = int.TryParse(input, out int userNumber);

                while (!success)
                {
                    Console.Clear();
                    Console.WriteLine("Välkommen till primtalskollen!\n----------------");
                    Console.Write("Felaktig inmatning, ange ett heltal: ");
                    input = Console.ReadLine();
                    success = int.TryParse(input, out userNumber);
                }

                if (userNumber == 2)
                {
                    Console.Write($"Talet {userNumber} är ett primtal");
                }
                else if (userNumber <= 1)
                {
                    Console.Write($"Talet {userNumber} är inte ett primtal");
                }
                else if (userNumber % 2 == 0)
                {
                    Console.Write($"Talet {userNumber} är jämnt och således inte ett primtal");
                }
                else
                {
                    bool isPrime = true;
                    double squareRoot = Math.Sqrt(userNumber);

                    for (int i = 2; i <= squareRoot; i++)
                    {
                        if (userNumber % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                        Console.Write($"Talet {userNumber} är ett primtal");
                    else
                        Console.Write($"Talet {userNumber} är inte ett primtal");
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
