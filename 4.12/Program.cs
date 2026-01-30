namespace _4._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            { 
                Console.Write("Ange första talet: ");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ange andra talet: ");
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ange räknesätt: ");
                string calculationMethod = Console.ReadLine();
                int answer = 0;

                switch (calculationMethod) 
                {
                    case "+":
                        answer = firstNumber + secondNumber;
                        Console.WriteLine($"{firstNumber} + {secondNumber} = {answer}");
                        break;
                    case "-":
                        answer = firstNumber - secondNumber;
                        Console.WriteLine($"{firstNumber} - {secondNumber} = {answer}");
                        break;
                    case "*":
                        answer = firstNumber * secondNumber;
                        Console.WriteLine($"{firstNumber} * {secondNumber} = {answer}");
                        break; 
                    default:
                        Console.WriteLine("Ogiltigt räknesätt");
                        break;
                }
            }
        }
    }
}
