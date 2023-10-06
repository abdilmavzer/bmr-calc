using System;
using System.Collections.Generic;

namespace Les3_Linked
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> todoList = new LinkedList<string>();

            while (true)
            {
                Console.WriteLine("Enter a task or write quit to exit: ");
                string input = Console.ReadLine();

                if (input == "quit")
                {
                    break;
                }
                todoList.AddLast(input);
            }

                Console.WriteLine("your TODO list: ");

                foreach (var element in todoList)
                {
                    Console.WriteLine(element);
                }
            
        }
    }
}