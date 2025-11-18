namespace Övning_7._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Get discount\n-------------");
            int personAge = 66;
            bool personIsUnder12 = false;
            bool personIsOver65 = false;
            bool isStudent = false;
            bool getsTicketDiscount = false;

            if (personAge < 12)
                personIsUnder12 = true;

            if (personAge > 65)
                personIsOver65 = true;

            if (personIsUnder12 || personIsOver65)
                getsTicketDiscount = true;

            if (personAge < 25 && isStudent)
                getsTicketDiscount = true;

            Console.WriteLine($"Personen är {personAge} och isStudent är {isStudent} och " +
                $"därav är getTicketsDiscount {getsTicketDiscount}");
        }
    }
}
