namespace Övning_9._3___Rövarspråket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rövarspråket\n-------------------------");
            Console.Write("Skriv in text att rövarspråka: ");
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if ("aieouåäö,. ".Contains(c))
                    Console.Write(c);
                //else if (c == ' ')
                //    Console.Write(' ');
                else
                    Console.Write($"{c}o{c}");
            }
        }
    }
}
