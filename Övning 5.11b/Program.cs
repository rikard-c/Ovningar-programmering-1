using System.Threading;

namespace Övning_5._11b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = 15, minutes = 21, seconds = 55;
            
            while (true) 
            {
                while (hours < 24) 
                { 
                    while(minutes < 60) 
                    { 
                        while (seconds  < 60) 
                        {
                            Console.Clear();
                            Console.Write(hours+":");
                            Console.Write(minutes+":");
                            Console.Write(seconds.ToString("D2"));
                            //Console.Write(seconds < 10 ? "0" + seconds : seconds);
                            System.Threading.Thread.Sleep(1000);
                            seconds++;
                        }
                        minutes++;
                        seconds = 0;
                    }
                    hours++;
                    minutes = 0;
                }
                hours = 0;
            }
        }
    }
}
