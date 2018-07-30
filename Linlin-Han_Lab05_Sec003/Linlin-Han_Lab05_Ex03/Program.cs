using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linlin_Han_Lab05_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            string id;
            string name;
            Student student = new Student("123","Alice");
            LinkedList<Student> lnkStudent = new LinkedList<Student>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter the student ID:");
                id = Console.ReadLine();
                Console.WriteLine("Please enter the student name:");
                name = Console.ReadLine();
                student = new Student(id, name);
                AddLinkedListItem(lnkStudent, student);
            }
            Console.WriteLine("Print LinkedList after adding 5 students");
            PrintLinkedList(lnkStudent);
            

            Console.WriteLine();
            Console.WriteLine("Please enter the student's ID that you want to remove");
            id = Console.ReadLine();
            Console.WriteLine("Please enter the student's Name that you want to remove");
            name = Console.ReadLine();
            Student rmStudent = new Student(id, name);

            Console.WriteLine();
            Console.WriteLine("Print LinkedList after removing 1 student");
            RemoveLinkedListItem(lnkStudent, rmStudent);
            PrintLinkedList(lnkStudent);

            Console.WriteLine();
            Console.WriteLine("Please enter the student's ID that you want to search");
            id = Console.ReadLine();
            Console.WriteLine("Please enter the student's Name that you want to search");
            name = Console.ReadLine();
            Student searchStudent = new Student(id, name);
            Console.WriteLine("The index of the student is:"+ SearchLinkedListItem(lnkStudent, searchStudent));
            


        }// end of main

        public static void AddLinkedListItem<T>(LinkedList<T> lnk, T objectName)
        {
            lnk.AddLast(objectName);
        }

        public static void RemoveLinkedListItem(LinkedList<Student> lnkStudent, Student student)
        {
            LinkedListNode<Student> currentNode = lnkStudent.First;
            while (currentNode != null)
            {
                if (currentNode.Value.Id == student.Id && currentNode.Value.Name == student.Name)
                {
                    lnkStudent.Remove(currentNode);
                }
                else
                {
                    Console.WriteLine("The student ID or name does not exist!");
                }
                currentNode = currentNode.Next; // get next node             
            } // end while
        }

        public static int SearchLinkedListItem(LinkedList<Student> lnkStudent, Student student)
        {
            int index = 0;
            LinkedListNode<Student> currentNode = lnkStudent.First;
            while (currentNode != null)
            {
                if (currentNode.Value.Id == student.Id && currentNode.Value.Name == student.Name)
                {
                    lnkStudent.Remove(currentNode);
                }
                else
                {
                    Console.WriteLine("The student ID or name does not exist!");
                    index = -1;
                }
                currentNode = currentNode.Next; // get next node  
                index++;
            } // end while

            return index;
        }


        public static void PrintLinkedList<T>(LinkedList<T> lnk)
        {
            LinkedListNode<T> currentNode = lnk.First;
            while (currentNode != null)
            {
                // get value in node       
                Console.WriteLine($"\n Student ID: {currentNode.Value}"); 
                currentNode = currentNode.Next; // get next node             
            } // end while
        }


    }


}
