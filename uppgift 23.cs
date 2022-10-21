using System;
using System.Runtime.CompilerServices;

namespace uppgift_4._23
{
    class program
    {
        static void Main(string[] args)
        {
            int nn = 0;
            while (true)
            {
                Console.WriteLine("Write another number if you want or just press n to stop.");
                string ch = Console.ReadLine();
                if (ch == "n")
                {
                    break;
                }
                else 
                {

                }
                if (int.Parse(ch) > nn)
                {
                    nn = int.Parse(ch);
                }
            }
            Console.WriteLine($"the biggest number you wrote is {nn}.");
        }
    }
}
