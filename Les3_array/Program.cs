using System;
using System.IO.Enumeration;

namespace Les3_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1, 5, 6, 3, 2, 5};

            int max = VindMax(numbers);
            
            Console.WriteLine(max);
            
        }

        public static int VindMax(int[] arr)
        {
            if (arr.Length == 0)
            {
                throw new ArgumentException("De lijst is leeg");
            }

            int max = arr[0];
            
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i]; 
                }
            }
            
            return max;
        }
    }
}