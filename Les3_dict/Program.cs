using System;
using System.Collections.Generic;

namespace Les3_dict
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();

            students.Add(4, "hamit");
            students.Add(2, "yusuf");
            students.Add(7, "Abdil");
            students.Add(8, "teyfun");
            
            Console.WriteLine("All students");
            foreach (var student in students)
            {
                Console.WriteLine($"Stundent ID : {student.Key} , name: {student.Value}");
            }
            
            
        }
    }
}


//ARRAY 
// Memory : they have a fixed size, pre-allocated for all elements
// Time complexity : read, write = constant time || insertion, deletion = linear time || insertion, deletion at the end = constant
// Efficacy : efficient when you know the size of the data in advance. BUT not efficient for dynamic sizing and insertion, removal in the middle of array

//LIST
// Memory : dynamic arrays, they can grow or shrink, memory allocated in chuncks, not all memory is used if list is small
// Time complexity : acces by index = constant || insertion or deletion in the beginning or end = constant, insertion or deletion in middle = linear
// Efficacy : efficient for dynamic resizing and when you need to remove or insert elements frequently

//LINKES LIST
// Memory : consists of nodes, each containing data and a reference to the next node
// Time complexity : acces by index = linear time || in or del at the beginning = constant || in or del at the end = linear || in or del in middle = constant
// Efficacy : efficient for insertion/removal at the beginning,middel, middle and for dynamic resizing, NOT efficient for random acces by index

//DICTIONARY:
// memory : allocate memory dynamically based on the numbers of elements
// Time complexity : insertion, deletion and retrieval of elements = constant time 
// Efficacy : efficient for fast lookups, insertions and deletions when you have large datasets, used for implenting datasturctures liek sets, maps and aarays