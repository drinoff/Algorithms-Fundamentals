using System;
using System.Linq;

namespace RecursiveArraySum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(RecursiveArraySum(arr,0));

            static int RecursiveArraySum(int[] arr,int index)
            {
                if (index == arr.Length-1)
                {
                    return arr[arr.Length - 1];
                }
                var sum = arr[index] + RecursiveArraySum(arr, index + 1);
                    return sum;
            }
        }
    }
}
