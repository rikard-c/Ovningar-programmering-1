namespace Övning_8._11___Faktorisering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("PRIMTALSFAKTORISERING\n---------------------------------");
                int userNumber = checkSubmittedNo("Ange ett heltal: ");

                int i = 2;
                bool firstPrinted = false;

                if (isPrimeMethod(userNumber))
                {
                    Console.WriteLine($"{userNumber} är ett primtal och kan därför inte faktoriseras. ");
                }
                else
                {
                    Console.Write($"{userNumber} = ");
                    while (i < userNumber)
                    {
                        if (isPrimeMethod(i))
                        {
                            int j = userNumber;
                            while (j % i == 0)
                            {
                                if (firstPrinted)
                                    Console.Write("*");
                                Console.Write($"{i}");
                                firstPrinted = true;
                                j = j / i;
                            }
                        }
                        i++;
                    }
                }
                Console.ReadKey();
                Console.Clear();
            }

        }
        static int checkSubmittedNo(string message)
        {
            int result = 0;
            Console.Write(message);
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.Write("Felaktig inmatning! Ange ett heltal: ");
            }
            return result;
        }

        static bool isPrimeMethod(int number)
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
    }
}
