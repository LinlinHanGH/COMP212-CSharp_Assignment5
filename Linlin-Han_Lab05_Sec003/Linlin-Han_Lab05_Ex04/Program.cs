using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linlin_Han_Lab05_Ex04
{
    class Program
    {
        private static int key = 0;
        static void Main(string[] args)
        {
            Employee[] employees = new[] {new Employee("Alice", 1000),
                                        new Employee("Bill", 1200),
                                        new Employee("Ella", 1000),
                                        new Employee("Vivian", 800),
                                        new Employee("David", 900)
                                        };

            SortedDictionary<int, Employee> employeeDict = new SortedDictionary<int, Employee>();

            for (int i = 0; i < employees.Length; ++i)
            {
                AddDictionaryItem(employeeDict, employees[i]);
            }

            Console.WriteLine("Print employeeDict after adding");
            PrintDictionary(employeeDict);

            Console.WriteLine("Print employeeDict after removing all");
            RemoveDictionaryItem(employeeDict);


        }

        public static void AddDictionaryItem(SortedDictionary<int, Employee> employeeDict, Employee emp)
        {
            employeeDict.Add(++key, emp);
        }

        public static void RemoveDictionaryItem(SortedDictionary<int, Employee> employeeDict) {
            employeeDict.Clear();
        }

        public static void PrintDictionary(SortedDictionary<int, Employee> employeeDict) {
            foreach (var key in employeeDict.Keys)
            {
                Console.WriteLine($" Key:{key} , Value:{employeeDict[key]}");
            }
        }
    }
}
