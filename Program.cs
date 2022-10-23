using System;

namespace uppgift_4._27
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pls write a messige.");
            string m = Console.ReadLine();
            Console.WriteLine("Pls write how many spaces to the right do you want you messege to be.");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < m.Length; i++)
            {
                
                for (int j = 0; j < n; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(m[i]);
            }
        }
    }
}