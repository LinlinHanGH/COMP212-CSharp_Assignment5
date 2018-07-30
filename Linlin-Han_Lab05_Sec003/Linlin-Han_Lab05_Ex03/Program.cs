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

            //for (int i = 0; i < 5; i++) {
            //    Console.WriteLine("Please enter the student ID:");
            //    id = Console.ReadLine();
            //    Console.WriteLine("Please enter the student name:");
            //    name = Console.ReadLine();
            //    student = new Student(id, name);
            //    AddLinkedListItem(lnkStudent, student);
            //}
            //Console.WriteLine("Print LinkedList after adding 5 students");
            //PrintLinkedList(lnkStudent);

            AddLinkedListItem(lnkStudent, student);
            Console.WriteLine("Please enter the student's ID that you want to remove");
            id = Console.ReadLine();
            Console.WriteLine("Please enter the student's Name that you want to remove");
            name = Console.ReadLine();
            Student rmStudent = new Student(id, name);

            RemoveLinkedListItem(lnkStudent, rmStudent);
            Console.WriteLine("Print LinkedList after removing 1 student");
            PrintLinkedList(lnkStudent);




        }// end of main

        public static void AddLinkedListItem(LinkedList<Student> lnkStudent, Student student)
        {
            lnkStudent.AddLast(student);
        }

        public static void RemoveLinkedListItem(LinkedList<Student> lnkStudent, Student student) {
            LinkedListNode<Student> currentNode = lnkStudent.First;
            while (currentNode != null)
            {
                if (currentNode.Value.Id == student.Id && currentNode.Value.Name == student.Name)
                {
                    lnkStudent.Remove(currentNode);
                }

                else {
                    Console.WriteLine("The student ID or name does not exist!");
                }

                currentNode = currentNode.Next; // get next node             
            } // end while

        }

        public static void PrintLinkedList(LinkedList<Student> lnkStudent)
        {
            LinkedListNode<Student> currentNode = lnkStudent.First;
            while (currentNode != null)
            {
                // get value in node       
                Console.WriteLine($"\n Student ID: {currentNode.Value.Id}"); // convert to uppercase 
                Console.WriteLine($" Student Name: {currentNode.Value.Name}");
                currentNode = currentNode.Next; // get next node             
            } // end while
        }
    }
}
