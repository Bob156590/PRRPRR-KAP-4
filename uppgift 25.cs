using System;

namespace uppgift_4._25
{
    class program
    {
        static void Main(string[] args)
        {
            bool chekining = true;
            while (chekining)
            {
                Console.WriteLine("Välj ett av följande alternativ.\n1. Subtrahera ett tal med ett annat\n2. Dividera ett tal med ett annat\n3. Avsluta programmet");
                int svar = int.Parse(Console.ReadLine());

                switch (svar)
                {
                    case 1:
                        Console.WriteLine("Pls write two numbers one after the other.");
                        double n1 = double.Parse(Console.ReadLine());
                        double n2 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"That will come out to {n1 - n2}\n");
                        continue;
                    case 2:
                        Console.WriteLine("Pls write two numbers one after the other.");
                        double n3 = double.Parse(Console.ReadLine());
                        double n4 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"That will come out to {n3 / n4}\n");
                        continue;
                    default:
                        chekining=false;
                        break;
                }
            }
        }
    }
}
