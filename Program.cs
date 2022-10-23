using System;

namespace uppgift_4._28
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pls write a sentens.");
            string str1 = Console.ReadLine();
            Console.WriteLine("Pls write some latters and the program will find if you used any of the letter in the first letter.");
            string str2 = Console.ReadLine();
            bool flag = false;
            str1.ToLower();
            str2.ToLower();
            for (int i = 0; i < str1.Length; i++)
            {
                if (str2[i] == str1[i])
                {
                    flag = true;
                }

                if (flag)
                {
                    Console.WriteLine("You used some of the letters.");
                }
                else
                {
                    Console.WriteLine("You didn't use any of the letters.");
                }

            }
        }
    }
}