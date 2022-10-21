using System;

namespace uppgift_4._25
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write a number pls.");
            string n = Console.ReadLine();

            for (int i = 0; i < n.Length; i++)
            {
                string s = n[i].ToString();
                int num = int.Parse(s);
                int num2 = (num + 1);
                Console.Write(num2);
            }
        }
    }
}