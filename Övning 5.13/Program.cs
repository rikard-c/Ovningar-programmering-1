using System.Numerics;

namespace Övning_5._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            double result = 0;
            Console.WriteLine("Beräkna fakultet");
            Console.WriteLine("-----------------");
            Console.Write("Ange n (hetltal): ");
            while (!int.TryParse(Console.ReadLine(), out  number))
            {
                Console.Write("Inte ett heltal, försök igen: ");            
            }
            result = number;
            for (int i = number - 1; i >= 1; i--) 
            {
                Console.WriteLine(result + " * " + i + " = " + (result *= i));
            }
            Console.WriteLine($"{number}! = {result}");
        }
    }
}
