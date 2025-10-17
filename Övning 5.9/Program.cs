namespace Övning_5._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            { 
            Console.Write("Ange multiplikationstabell (heltal): ");
            int number = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{number} * {i} = {number*i}");
                }
            }
        }
    }
}
