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
        }

        public static void AddDictionaryItem(SortedDictionary<int, Employee> employeeDict, Employee emp)
        {
            employeeDict.Add(++key, emp);
        }
    }
}
