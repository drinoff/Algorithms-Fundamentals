using System;

namespace recursiveFactoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(RecursiveFactoriel(n));

            static int RecursiveFactoriel(int n)
            {
                if(n == 1)
                {
                    return 1;
                }
                var sum = n * RecursiveFactoriel(n - 1);
                return sum;
            }
        }
    }
}
