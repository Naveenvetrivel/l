using System;

namespace alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int n;
            Console.WriteLine("Enter the Number of Rows : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write((char)(j + 64));
                }

                Console.WriteLine("");
            }
        }
    }
}
