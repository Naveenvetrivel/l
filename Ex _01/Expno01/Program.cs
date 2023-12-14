using System;

namespace Expno01
{
    class Eligibility
    {
        static void Main(string[] args)
        {
            string name;
            int math, phy, chem;
            Console.Write("Enter your name:");
            name = Console.ReadLine();
            Console.Write("Enter Maths Mark:");
            math = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Physics Mark:");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Chemistry Mark:");
            chem = Convert.ToInt32(Console.ReadLine());
            int tot1 = math + phy + chem;
            int tot2 = math + phy;
            if (math >= 65 && phy >= 55 && chem >= 50)
            {
                if (tot1 >= 180 || tot2 >= 140)
                {
                    Console.WriteLine(name + " is eligible for admission to an engineering course.");
                }
                else
                {
                    Console.WriteLine(name + " is not eligible for admission to an engineering course.");
                }
            }
            else
            {
                Console.WriteLine(name + " is not eligible for admission to an engineering course.");
            }
            Console.Read();
        }
    }
}