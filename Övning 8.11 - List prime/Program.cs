namespace Övning_8._11___List_prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Välkommen till primtalslistningen!\n-------------------------------------\n");
                int userNumber = checkSubmittedNo("Mata in ett primtal: ");
                Console.WriteLine($"\nHär följer en lista av primtal upp till talet {userNumber}\n");
                Console.Write("2 ");
                int printThePrime = 3;
                int rowCounter = 1;
                while (printThePrime < userNumber)
                {
                    if (isPrimeMethod(printThePrime))
                    {
                        Console.Write($"{printThePrime} ");
                        if (rowCounter % 15 == 0)
                        {
                            Console.WriteLine("\n");
                        }
                        rowCounter++;
                    }
                    printThePrime += 2;
                }
                Console.Write(userNumber);
                Console.ReadKey();
                Console.Clear();
            }

            bool isPrimeMethod(int number)
            {
                bool isNumberPrime = true;

                if (number == 2)
                {
                    isNumberPrime = true;
                }
                else if (number <= 1)
                {
                    isNumberPrime = false;
                }
                else if (number % 2 == 0)
                {
                    isNumberPrime = false;
                }
                else
                {
                    double squareRoot = Math.Sqrt(number);

                    for (int i = 2; i <= squareRoot; i++)
                    {
                        if (number % i == 0)
                        {
                            isNumberPrime = false;
                            break;
                        }
                    }
                }
                return isNumberPrime;
            }

            int checkSubmittedNo(string message)
            {
                int result = 0;
                Console.Write(message);
                while (!int.TryParse(Console.ReadLine(), out result))
                {
                    Console.Clear();
                    Console.WriteLine("Välkommen till primtalslistningen!\n-------------------------------------\n");
                    Console.Write("Felaktig inmatning! ");
                    Console.Write(message);
                }
                return result;
            }
        }
    }
}
