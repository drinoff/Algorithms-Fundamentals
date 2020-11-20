using System;
using System.Collections.Generic;

namespace recursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<int, int>();
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(RecursiveFibonacci(n, dict));

            static int RecursiveFibonacci(int n, Dictionary<int, int> dict)
            {
                

                if (n <= 1)
                {
                    return 1;
                }

                if (dict.ContainsKey(n))
                {
                    return dict[n];
                }

                var fibForN = RecursiveFibonacci(n - 1, dict) + RecursiveFibonacci(n - 2, dict);
                dict.Add(n, fibForN);

                return fibForN;

            }
        }
    }
}
