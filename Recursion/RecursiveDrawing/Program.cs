﻿using System;
using System.Text;

namespace RecursiveDrawing
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            
            Draw(n);

            static void Draw(int n)
            {
                if(n == 0)
                {
                    return;
                }
                Console.WriteLine(new string('*',n));
                Draw(n - 1);
                Console.WriteLine(new string('#',n));

            }
        }
    }
}
