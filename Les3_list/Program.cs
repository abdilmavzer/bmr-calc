using System;
using System.Collections.Generic;

namespace Les3_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int> {1, 2, 3, 4, 5};
            
            Console.WriteLine(myList[2]);
            
            myList.Add(6);
            myList.RemoveAt(1);
            
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }
}