namespace Övninig_4._18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decimaltal till binärtal");
            Console.WriteLine("-----------------");
            while (true) 
            { 
                int quotient;
                string result = "";
                Console.Write("Ange ett decimaltal: ");
                int submitedNumber = Convert.ToInt32(Console.ReadLine());
                quotient = submitedNumber;
                while (quotient > 0) 
                {
                    result = $"{quotient % 2}" + result;
                    quotient = quotient / 2;
                }
                if(submitedNumber == 0) 
                    result = "0";
                Console.WriteLine($"{submitedNumber} ser ut så här binärt: {result}");
            }
        }
    }
}
