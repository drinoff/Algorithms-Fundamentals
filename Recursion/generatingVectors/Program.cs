using System;

namespace generatingVectors
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var vector = new int[n];

            GenerateVectors(vector, 0);

            static void GenerateVectors(int[] vector, int index)
            {
                if (index >= vector.Length)
                {
                    Console.WriteLine(string.Join("", vector));
                }
                else
                {
                    for (int i = 0; i <= 1; i++)
                    {
                        vector[index] = i;
                        GenerateVectors(vector, index + 1);
                    }
                }
            }
        }
    }
}
