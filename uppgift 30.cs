using System;

namespace uppgift_4._30
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many X's?");
            int c1 = int.Parse(Console.ReadLine());
            Console.WriteLine("How many O's?");
            int c2 = int.Parse(Console.ReadLine());
            Console.WriteLine("How many O patterns per row?");
            int c3 = int.Parse(Console.ReadLine());
            Console.WriteLine("How many columns?");
            int c4 = int.Parse(Console.ReadLine());
            int j = 0;
            int k = 0;
            int l = 0;
            for (int i = 0; i < c4; i++)
            {
                j = 0;
                k = 0;
                l = 0;
                do
                {
                    do
                    {
                        Console.Write("X");
                        j++;
                    }while (j < c1);
                    Console.Write("-");
                    j=0;
                    do
                    {
                        Console.Write("O");
                        k++;
                    } while (k < c2);
                    Console.Write("-");
                    l++;
                }while (l < c3);
                do
                {
                    Console.Write("X");
                    j++;
                } while (j < c1);
                Console.WriteLine();
            }
        }
    }
}
