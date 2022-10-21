using System;

namespace uppgift_4._24
{
    class program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    continue;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    continue;
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FuzzBuzz");
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
