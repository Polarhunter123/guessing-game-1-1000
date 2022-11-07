using System.Net.Security;

namespace program1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int max = 1000;
            int Number = rnd.Next(1, max+1);
            Console.WriteLine($"Gita eitt tal millum 1-{max}");
            int A = Int32.Parse(Console.ReadLine());
            Console.WriteLine("...");
            int Counter=1;
            while(Counter <10)
            {
                if (A == Number)
                {
                    break;
                }
                if (A > Number)
                {
                    Console.WriteLine("Talid er minni");
                }
                if (A < Number)
                {
                    Console.WriteLine("Talid er størri");
                }
                Console.WriteLine("vel eitt nýtt tal");
                A = Int32.Parse(Console.ReadLine());
                Counter = Counter + 1;
            }
            if (A == Number)
            {
                Console.WriteLine("You Win");
            }
            if (Counter == 10 && A != Number)
            {
                Console.WriteLine("Game Over, the number was:");
                Console.WriteLine(Number);
            }










           
            
            


        }
    }
}