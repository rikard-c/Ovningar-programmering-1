namespace Övning_5._16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int currentRow = 1;
   
            while (currentRow <= 9)
            {
                int noOfA = 1;
                while (noOfA <= currentRow)
                {
                    Console.Write("a");
                    noOfA++;
                }

                int noOfB = 1;
                while (noOfB <= 10 - currentRow)
                {
                    Console.Write("b");
                    noOfB++;
                }

                currentRow++;
                noOfB--;
                Console.WriteLine();
            }
        }
    }
}
