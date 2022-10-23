using System;

namespace uppgift_4._29
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pls the hight for the triangel.");
            int h = int.Parse(Console.ReadLine());
            int j = 0;
            for (int i = 0; i < h; i++)
            {
                do
                {
                    Console.Write("*");
                    j++;
                } while (j <= i);
                Console.WriteLine();
                j = 0;
            }
        }
    }
}
