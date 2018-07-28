using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linlin_Han_Lab05_Ex02
{
    class Program
    {
        public static void Main(string[] args)
        {
            // create arrays of int, double and char
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

            Console.Write("Array intArray contains: ");
            DisplayArray(intArray); // pass an int array argument
            Console.Write("Array doubleArray contains: ");
            DisplayArray(doubleArray); // pass a double array argument
            Console.Write("Array charArray contains: ");
            DisplayArray(charArray); // pass a char array argument
            Console.WriteLine();
            DisplayArray(intArray, 0, 1);
        }

        // output array of all types                           
        private static void DisplayArray<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }

        //version 2.0 and assignment 5
        private static void DisplayArray<Type1>(Type1[] inputArray, int lowIndex, int highIndex)
        // validation: cannot be negitive
        // validation: less than length
        // validation: highIndex should be bigger than lowIndex
        {

            for (int i = lowIndex; i <= highIndex; i++)
            {
                Console.WriteLine(inputArray[i]);
            }


            Console.WriteLine();
        }
    }
}
