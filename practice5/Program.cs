using System;

namespace practice5
{
    class Program
    {
        //MohammadReza Fatahi
        //tamrin5
        static void Main(string[] args)
        {
            first:
            Console.WriteLine("adad mored nazar ra baraye mohasebe factoriel an vared konid :");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 1;
            for (int i = 1; i <= a; i++)
                b *= i;
            Console.WriteLine(b);
            Console.WriteLine("aya mikhay edame bedi?! (y/n)");
            string x = Console.ReadLine();
            if (x == "y")
            {
                goto first;
            }
            else
            {
                Console.WriteLine("khodafez");
            }
        }
    }
}
