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
            Console.WriteLine();

            Console.WriteLine("--------valid arguments------------");
            Console.WriteLine("Display intArray -- lowIndex:1 highIndex:1");
            DisplayArray(intArray, 1, 1);

            Console.WriteLine("Display doubleArray -- lowIndex:0 highIndex:3");
            DisplayArray(doubleArray, 0, 3);

            Console.WriteLine("Display charArray -- lowIndex:2 highIndex:4");
            DisplayArray(charArray, 2, 4);
            Console.WriteLine();

            Console.WriteLine("--------invalid arguments-----------");
            Console.WriteLine("Display intArray -- lowIndex:-1 highIndex:1");
            DisplayArray(intArray, -1, 1);

            Console.WriteLine("Display doubleArray -- lowIndex:2 highIndex:1");
            DisplayArray(doubleArray, 2, 1);

            Console.WriteLine("Display charArray -- lowIndex:2 highIndex:20");
            DisplayArray(charArray, 2, 20);
            Console.WriteLine();
      
           
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
            if (lowIndex < 0 || highIndex < 0)
            {
                try
                {
                    throw new ArgumentException("The Index number cannot be less than 0.");
                }
                catch(Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }
            else if (lowIndex > highIndex)
            {
                try
                {
                    throw new ArgumentException("The lowIndex number must be less than the highIndex number.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
            else if (lowIndex > inputArray.Length - 1 || highIndex > inputArray.Length - 1)
            {
                try
                {
                    throw new ArgumentException("The index number cannot be more than the length of the array");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
            else {
                for (int i = lowIndex; i <= highIndex; i++)
                {
                    Console.Write($"{inputArray[i]} ");
                }
            }
            
            Console.WriteLine();
        }
    }
}
