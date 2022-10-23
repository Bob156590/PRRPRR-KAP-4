using System;
using System.Drawing;

namespace uppgift_4._31
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determine the side length of the squares");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Determine the width of the grid");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Determine the height of the grid");
            int n3 = int.Parse(Console.ReadLine());
            int l = 0;
            for (int i = 0; i < n3; i++)
            {
                for(int j = 0; j < n1; j++)
                {
                    l = 0;
                    do
                    {
                        Console.Write("***** ");
                        l++;
                    } while (l < n2);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            l = 0;
            do
            {
                Console.Write("***** ");
                l++;
            } while (l < n2);
        }
    }
}